using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CFB___Academia
{
    public partial class F_GestaoProfessores : Form
    {
        public F_GestaoProfessores()
        {
            InitializeComponent();
        }

        private void F_GestaoProfessores_Load(object sender, EventArgs e)
        {
            string vquery = @"

            select Id_Professor as ID, Nome_Professor as Professor, Telefone 
            from tab_Professores  
            order by Id_Professor
";
            dgv_Professores.DataSource = Banco.DQL(vquery);
            dgv_Professores.Columns[0].Width = 60;
            dgv_Professores.Columns[1].Width = 170;
            dgv_Professores.Columns[2].Width = 100;
        }

        private void btn_novoProfessor_Click(object sender, EventArgs e)
        {
            tb_idProfessor.Clear();
            tb_NomeProfessor.Clear();
            mtb_telefone.Clear();
            tb_NomeProfessor.Focus();
        }

        private void btn_salvarProfessor_Click(object sender, EventArgs e)
        {
            string vquery;
            if (tb_idProfessor.Text == "")
            {
                vquery = @"insert into tab_professores (Nome_Professor, Telefone) values ('"+tb_NomeProfessor.Text+"','"+mtb_telefone.Text+"')";
            }
            else
            {
                vquery = @"update tab_professores set Nome_Professor='"+tb_NomeProfessor.Text+"', Telefone='"+mtb_telefone.Text+"'where Id_Professor="+tb_idProfessor.Text;
            }
            Banco.DML(vquery);
            vquery = @"
            select
            Id_Professor as ID,
            Nome_Professor as Professor,
            Telefone
            from tab_professores 
            order by Id_Professor
";
            dgv_Professores.DataSource = Banco.DQL(vquery);
        }

        private void btn_excluirProfessor_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Confirma exclusão?", "Excluir",MessageBoxButtons.YesNo);
            if(res == DialogResult.Yes)
            {
                string vquery = @"delete from tab_professores where Id_Professor=" + tb_idProfessor.Text;
                Banco.DML(vquery);
                dgv_Professores.Rows.Remove(dgv_Professores.CurrentRow);
            
            }
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgv_Professores_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contlinahs = dgv.SelectedRows.Count;
            if (contlinahs > 0)
            {
                DataTable dt = new DataTable();
                string vid = dgv.SelectedRows[0].Cells[0].Value.ToString();
                string vquery = @"

                select * from tab_professores where Id_Professor=" + vid;

                dt = Banco.DQL(vquery);
                tb_idProfessor.Text = dt.Rows[0].Field<Int64>("Id_Professor").ToString();
                tb_NomeProfessor.Text = dt.Rows[0].Field<string>("Nome_Professor");
                mtb_telefone.Text = dt.Rows[0].Field<string>("Telefone");



            }
        }
    }
}
