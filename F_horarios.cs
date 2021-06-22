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
    public partial class F_horarios : Form
    {
        public F_horarios()
        {
            InitializeComponent();
        }

        private void F_horarios_Load(object sender, EventArgs e)
        {
            string vquery = @"
            select Id_Horario as id, Horario from tab_horarios
                order by Horario ";
            dgv_Horarios.DataSource = Banco.DQL(vquery);
            dgv_Horarios.Columns[0].Width = 60;
            dgv_Horarios.Columns[1].Width = 170;

        }

        private void dgv_Horarios_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contlinahs = dgv.SelectedRows.Count;
            if (contlinahs > 0)
            {
                DataTable dt = new DataTable();
                string vid = dgv.SelectedRows[0].Cells[0].Value.ToString();
                string vquery = @"

                select * from tab_horarios where Id_Horario="+ vid;

                dt = Banco.DQL(vquery);
                tb_ID.Text = dt.Rows[0].Field<Int64>("Id_Horario").ToString();
                mtb_horario.Text = dt.Rows[0].Field<string>("Horario");



            }
        }

        private void btn_novoHorario_Click(object sender, EventArgs e)
        {
            tb_ID.Clear();
            mtb_horario.Clear();
            mtb_horario.Focus();
        }

        private void btn_salvarHoraio_Click(object sender, EventArgs e)
        {
            string vquery;
            if (tb_ID.Text == "")
            {
                vquery ="insert into tab_horarios (Horario) values('" + mtb_horario.Text + "')";
            }
            else
            {
                vquery = "update tab_horarios set Horario='" + mtb_horario.Text + "' where Id_Horario="+tb_ID.Text;
            }                
            Banco.DML(vquery);
            vquery = @"
            select Id_Horario as id, Horario from tab_horarios
                order by Horario
";
            dgv_Horarios.DataSource = Banco.DQL(vquery);

        }

        private void btn_excluirHoraio_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Confirma exclusão?", "Excluir", MessageBoxButtons.YesNo);
            if(res== DialogResult.Yes)
            {
                string query = "delete from tab_horarios where Id_Horario=" + tb_ID.Text;
                Banco.DML(query);
                dgv_Horarios.Rows.Remove(dgv_Horarios.CurrentRow);

            }
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
