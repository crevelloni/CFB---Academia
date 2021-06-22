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
    public partial class F_Gestao_Alunos : Form
    {
        string vQueryDGV = "";
        string turmaAtual = "";
        string idSelecionado = "";
        string turma = "";
        int linha = 0;

        public F_Gestao_Alunos()
        {
            InitializeComponent();
        }

        private void F_Gestao_Alunos_Load(object sender, EventArgs e)
        {
             vQueryDGV = @"
                select 
                    Id_Aluno as 'ID',
                    Nome_Aluno as 'Aluno'
                from 
                    tab_alunos
";
            dgv_alunos.DataSource = Banco.DQL(vQueryDGV);
            dgv_alunos.Columns[0].Width = 40;
            dgv_alunos.Columns[1].Width = 120;

            tb_nome.Text = dgv_alunos.Rows[dgv_alunos.SelectedRows[0].Index].Cells[1].Value.ToString();

            //POPULAR COMBO BOX TURMAS
            string vqueryTurmas = @"
                select 
                    Id_Turma,
                    ('Vagas: '|| (
                                    (Max_Alunos)-(
                                                   select 
                                                        count(tba.Id_Aluno)
                                                    from 
                                                        tab_alunos as tba
                                                    where 
                                                        tba.Status='A' and tba.Id_Turma=Id_Turma
                                                    )
                                    ) || '/ Turma: ' || Turma
                    ) as 'Turma'
                from
                    tab_turmas
                order by
                    Id_Turma
";
            cb_turmas_vagas.Items.Clear();
            cb_turmas_vagas.DataSource = Banco.DQL(vqueryTurmas);
            cb_turmas_vagas.DisplayMember = "Turma";
            cb_turmas_vagas.ValueMember = "Id_Turma";

            //Popular ComboBox Status (Ativo=A, Bloqueado=B, Cancelado=C)
            Dictionary<string, string> status = new Dictionary<string, string>();
            status.Add("A", "Ativo");
            status.Add("B", "Bloqueado");
            status.Add("C", "Cancelado");
            cb_status.DataSource = new BindingSource(status, null);
            cb_status.DisplayMember = "Value";
            cb_status.ValueMember = "Key";

            turma = cb_turmas_vagas.Text;
            turmaAtual = cb_turmas_vagas.Text;
            idSelecionado = dgv_alunos.Rows[0].Cells[0].Value.ToString();

        }

        private void dgv_alunos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
