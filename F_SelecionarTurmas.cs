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
    public partial class F_SelecionarTurmas : Form
    {
        F_Novo_Aluno formNovoAluno; 
        public F_SelecionarTurmas(F_Novo_Aluno f)
        {
            InitializeComponent();
            formNovoAluno = f;
        }

        private void F_SelecionarTurmas_Load(object sender, EventArgs e)
        {
            string queryTurmas = String.Format(@"

                Select 
                    tbt.Id_Turma as Id,
                    tbt.Turma as Turma,
                    th.Horario as Horario,
                    tp.Id_Professor as Professor,
                    tbt.Max_Alunos as 'Máx. Alunos',
                    ( select 
                           count(Id_Aluno)
                      from
                         tab_alunos as tal
                      where 
                         tal.Id_Turma =  tbt.Id_Turma and  tal.status = 'A'
                     ) as Qtde
                from
                    tab_turmas as tbt
                inner join
                    tab_professores as tp on tbt.Id_Professor = tp.Id_Professor
                inner join
                    tab_horarios th on tbt.Id_Horario = th.Id_Horario
");
            dgv_turmas.DataSource = Banco.DQL(queryTurmas);
        }

        private void dgv_turmas_DoubleClick(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int maxAlunos = 0;
            int qtdeAlunos = 0;
            maxAlunos = Int32.Parse(dgv.SelectedRows[0].Cells[4].Value.ToString());
            qtdeAlunos = Int32.Parse(dgv.SelectedRows[0].Cells[5].Value.ToString());

            if(qtdeAlunos >= maxAlunos)
            {
                MessageBox.Show("Não há vagas nesta turma");
            }
            else
            {
                formNovoAluno.tb_turma.Text = dgv.Rows[dgv.SelectedRows[0].Index].Cells[1].Value.ToString();
                formNovoAluno.tb_turma.Tag = dgv.Rows[dgv.SelectedRows[0].Index].Cells[0].Value.ToString();
                Close();

            }

        }
    }
}
