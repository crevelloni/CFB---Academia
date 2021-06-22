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
    public partial class F_GestaoUsuario : Form
    {
        public F_GestaoUsuario()
        {
            InitializeComponent();
        }

        private void F_GestaoUsuario_Load(object sender, EventArgs e)
        {
            dgv_usuarios.DataSource = Banco.GetUsersIdNome();
            dgv_usuarios.Columns[0].Width = 85;
            dgv_usuarios.Columns[1].Width = 190;
        }

        private void dgv_usuarios_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contlinhas = dgv.SelectedRows.Count;
            if (contlinhas > 0)
            {
                DataTable dt = new DataTable();
                string vId = dgv.SelectedRows[0].Cells[0].Value.ToString();
                dt=Banco.GetUsersData(vId);
                tb_id.Text = dt.Rows[0].Field<Int64>("N_Id_Usuario").ToString();
                tb_nome.Text = dt.Rows[0].Field<string>("T_NomeUsuario").ToString();
                tb_senha.Text = dt.Rows[0].Field<string>("T_Senha").ToString();
                tb_userNamw.Text = dt.Rows[0].Field<string>("T_userName").ToString();
                cb_status.Text = dt.Rows[0].Field<string>("T_StatusUsuario").ToString();
                nup_nivel.Value = dt.Rows[0].Field<Int64>("N_NivelUsuario");
            }  
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            F_NovoUsuario f_NovoUsuario = new F_NovoUsuario();
            f_NovoUsuario.ShowDialog();
            dgv_usuarios.DataSource = Banco.GetUsersIdNome();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            int linha = dgv_usuarios.SelectedRows[0].Index;
            Usuario u = new Usuario();
            u.id = Convert.ToInt32(tb_id.Text);
            u.nome = tb_nome.Text;
            u.senha = tb_senha.Text;
            u.usuario = tb_userNamw.Text;
            u.nivel =Convert.ToInt32(nup_nivel.Value);
            u.status=cb_status.Text;
            Banco.UpdateUser(u);
            dgv_usuarios.DataSource = Banco.GetUsersIdNome();
            dgv_usuarios.CurrentCell = dgv_usuarios[0, linha];
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Confirma exclusão?","Excluir", MessageBoxButtons.YesNo);
            if(res== DialogResult.Yes)
            {
                Banco.InativarUser(tb_id.Text);
                dgv_usuarios.Rows.Remove(dgv_usuarios.CurrentRow);
            }
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
