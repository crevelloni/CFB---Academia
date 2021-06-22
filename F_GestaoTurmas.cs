using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace CFB___Academia
{
    public partial class F_GestaoTurmas : Form
    {
        string idSelecionado;
        int modo = 0;//0=padrão, 1=edição, 2=inserção
        string vqueryDGV;
        public F_GestaoTurmas()
        {
            InitializeComponent();
        }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void F_GestaoTurmas_Load(object sender, EventArgs e)
        {
            vqueryDGV = @" select
            tt.Id_Turma,
            tt.Turma,
            th.Horario
            from 
            tab_turmas tt
            inner join tab_horarios th on tt.Id_Horario = th.Id_Horario
";
            dgv_Turmas.DataSource = Banco.DQL(vqueryDGV);
            dgv_Turmas.Columns[0].Width = 40;
            dgv_Turmas.Columns[1].Width = 130;
            dgv_Turmas.Columns[2].Width = 130;

            //Popular combo box professores
            string vqueryProf = @" 
            select 
                Id_Professor,
                Nome_Professor
            from 
                tab_professores
            order by
                Id_Professor
            
";
            cb_professor.Items.Clear();
            cb_professor.DataSource = Banco.DQL(vqueryProf);
            cb_professor.DisplayMember = "Nome_Professor";
            cb_professor.ValueMember = "Id_Professor";

            //popular combobox status ativo=A, paralisada=P, cancelada=C

            Dictionary<string, string> st = new Dictionary<string, string>();
            st.Add("A", "Ativo");
            st.Add("P", "Paralisada");
            st.Add("C", "Cancelada");            
            cb_status.DataSource = new BindingSource(st,null);
            cb_status.DisplayMember = "Value"; 
            cb_status.ValueMember = "Key";

            // popular combobox horarios 
            string vqueryHor = @" 
            select 
               *
            from 
                tab_horarios
            order by
                Horario
            
";
            cb_Horarios.Items.Clear();
            cb_Horarios.DataSource = Banco.DQL(vqueryHor);
            cb_Horarios.DisplayMember = "Horario";
            cb_Horarios.ValueMember = "Id_Horario";
        }

        private void dgv_Turmas_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contLinhas = dgv.SelectedRows.Count;
            if (contLinhas > 0)
            {
                modo = 0;
                idSelecionado = dgv_Turmas.Rows[dgv_Turmas.SelectedRows[0].Index].Cells[0].Value.ToString();
                string vqueryCampos = @"
                select 
                    Turma,
                    Id_Professor,
                    Id_Horario,
                    Max_Alunos,
                    Status
                from
                    tab_turmas
                where 
                    Id_Turma="+idSelecionado;
                DataTable dt = Banco.DQL(vqueryCampos);
                tb_DescTurmas.Text = dt.Rows[0].Field<string>("Turma");
                cb_professor.SelectedValue = dt.Rows[0].Field<Int64>("Id_Professor").ToString();
                nud_maxAlunos.Value = dt.Rows[0].Field<Int64>("Max_Alunos");
                cb_status.SelectedValue = dt.Rows[0].Field<string>("Status");
                cb_Horarios.SelectedValue = dt.Rows[0].Field<Int64>("Id_Horario");

                //Cálculo de vagas

                string vagasQuery = String.Format(@"
                select 
                    count(Id_Aluno) as ContVagas
                from 
                    tab_alunos
                where 
                    Status='A' and Id_Turma={0}",idSelecionado);
                dt = Banco.DQL(vagasQuery);
                int vagas=Int32.Parse(Math.Round(nud_maxAlunos.Value).ToString());
                vagas -= Int32.Parse(dt.Rows[0].Field<Int64>("ContVagas").ToString());
                tb_vagas.Text = CalcVagas();

            }

        }
        private string CalcVagas()
        {
            //Cálculo de vagas

            string vagasQuery = String.Format(@"
                select 
                    count(Id_Aluno) as ContVagas
                from 
                    tab_alunos
                where 
                    Status='A' and Id_Turma={0}", idSelecionado);
            DataTable dt = Banco.DQL(vagasQuery);
            int vagas = Int32.Parse(Math.Round(nud_maxAlunos.Value).ToString());
            vagas -= Int32.Parse(dt.Rows[0].Field<Int64>("ContVagas").ToString());
            tb_vagas.Text = vagas.ToString();

            return vagas.ToString();
        }

        private void btn_NovaTurma_Click(object sender, EventArgs e)
        {
            tb_DescTurmas.Clear();
            cb_professor.SelectedIndex = -1;
            nud_maxAlunos.Value = 0;
            cb_status.SelectedIndex = -1;
            cb_Horarios.SelectedIndex = -1;
            tb_vagas.Clear();
            modo = 2;

        }

        private void btn_SalvarEdicoes_Click(object sender, EventArgs e)
        {
            if (modo != 0)
            {
                string queryTurma="";
                string msg = "";
                if (modo==1)
                {
                    msg = "Dados Alterados";
                    queryTurma = String.Format(@"
            update
                tab_turmas
            set
                Turma='{0}', Id_Professor={1}, Id_Horario={2}, Max_Alunos={3}, Status='{4}'
            Where 
                Id_Turma={5}", tb_DescTurmas.Text, cb_professor.SelectedValue, cb_Horarios.SelectedValue, Int32.Parse(Math.Round(nud_maxAlunos.Value, 0).ToString()), cb_status.SelectedValue, idSelecionado);

                }
                else
                {
                    msg = "Nova turma inserida";
                    queryTurma = String.Format(@"
            insert into tab_turmas
                     (Turma,Id_Professor,Id_Horario,Max_Alunos,Status)
                values ('{0}',{1},{2},{3},'{4}')",tb_DescTurmas.Text, cb_professor.SelectedValue, cb_Horarios.SelectedValue, Int32.Parse(Math.Round(nud_maxAlunos.Value, 0).ToString()), cb_status.Text);
                }
                int linha = dgv_Turmas.SelectedRows[0].Index;
                Banco.DML(queryTurma);
                if (modo == 1)
                {
                    dgv_Turmas[1, linha].Value = tb_DescTurmas.Text;
                    dgv_Turmas[2, linha].Value = cb_Horarios.Text;
                    tb_vagas.Text = CalcVagas();
                }            
                else
                {
                    dgv_Turmas.DataSource = Banco.DQL(vqueryDGV);
                }
                MessageBox.Show(msg);
            }
           
        }

        private void btn_ExcluirTurma_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Confirma exclusão", "Excluir", MessageBoxButtons.YesNo);
            if(res == DialogResult.Yes)
            {
                string queryExcluirTurma = string.Format(@"
                    delete
                    from    
                        tab_turmas
                    where
                        Id_Turma={0}", idSelecionado);
                Banco.DML(queryExcluirTurma);
                dgv_Turmas.Rows.Remove(dgv_Turmas.CurrentRow);
            }
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tb_DescTurmas_TextChanged(object sender, EventArgs e)
        {
            if (modo==0)
            {
                modo = 1;
            }
        }

        private void cb_professor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (modo == 0)
            {
                modo = 1;
            }
        }

        private void nud_maxAlunos_ValueChanged(object sender, EventArgs e)
        {
            if (modo == 0)
            {
                modo = 1;
            }
        }

        private void cb_status_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (modo == 0)
            {
                modo = 1;
            }
        }

        private void cb_Horarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (modo == 0)
            {
                modo = 1;
            }
        }

        private void tb_vagas_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void dgv_Turmas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_ImprimirTurma_Click(object sender, EventArgs e)
        {
            string nomeArquivo = Globais.caminho + @"\turmas.pdf";
            FileStream arquivoPDF = new FileStream(nomeArquivo, FileMode.Create);
            Document doc = new Document(PageSize.A4);
            PdfWriter escritorPDF = PdfWriter.GetInstance(doc, arquivoPDF);

            iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(Globais.caminho + @"\logo.jpeg");
            logo.ScaleToFit(140f, 120f);
            logo.Alignment = Element.ALIGN_LEFT;
            //logo.SetAbsolutePosition(100f, 700f);

            string dados = "";

            Paragraph paragrafo1 = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL,20,(int)System.Drawing.FontStyle.Bold));
            paragrafo1.Alignment = Element.ALIGN_CENTER;
            paragrafo1.Add("Relatório de Turmas");

            //paragrafo1.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14, (int)System.Drawing.FontStyle.Italic);         
            //paragrafo1.Add("Curso de C#");
            //string texto = "youtube.com/cfbcursos";
            //paragrafo1.Add(texto);

            Paragraph paragrafo2 = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12, (int)System.Drawing.FontStyle.Bold));
            paragrafo2.Alignment = Element.ALIGN_CENTER;
            paragrafo2.Add("CFB Cursos - Curso de C#");
            //paragrafo2.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12, (int)System.Drawing.FontStyle.Italic);
            //paragrafo2.Add(texto);

            PdfPTable tabela = new PdfPTable(3);
            tabela.DefaultCell.FixedHeight = 20;

            tabela.AddCell("Id_Turma");
            tabela.AddCell("Turma");
            tabela.AddCell("Horario");

            DataTable dtTurmas = Banco.DQL(vqueryDGV);
            for(int i = 0; i < dtTurmas.Rows.Count; i++)
            {
                tabela.AddCell(dtTurmas.Rows[i].Field<Int64>("Id_Turma").ToString());
                tabela.AddCell(dtTurmas.Rows[i].Field<string>("Turma"));
                tabela.AddCell(dtTurmas.Rows[i].Field<string>("Horario"));
            }

            //PdfPCell celula1 = new PdfPCell(new Phrase("tabela de preços"));
            //celula1.Colspan = 3;
            ////celula1.Rotation = 90;
            //celula1.AddElement(logo);
            //tabela.AddCell(celula1);

            //tabela.AddCell("Código");
            //tabela.AddCell("Produto");
            //tabela.AddCell("Preço");

            //tabela.AddCell("01");
            //tabela.AddCell("mouse");
            //tabela.AddCell("25,00");

            //tabela.AddCell("02");
            //tabela.AddCell("Teclado");
            //tabela.AddCell("685,00");

            //PdfPCell celula2 = new PdfPCell(new Phrase("tabela de preços  "));
            //celula2.Colspan = 3;
            //celula2.FixedHeight = 40;
            //celula2.Rotation = 0;
            //celula2.HorizontalAlignment = Element.ALIGN_CENTER;
            //celula2.VerticalAlignment = Element.ALIGN_MIDDLE;
            //tabela.AddCell(celula2);

            doc.Open();
            doc.Add(logo);
            doc.Add(paragrafo1);
            doc.Add(tabela);
            doc.Add(paragrafo2);          
            doc.Close();

            DialogResult res = MessageBox.Show("Deseja abrir o relatório?","Relatório", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start(Globais.caminho + @"\turmas.pdf");
            }

        }
    }
}
