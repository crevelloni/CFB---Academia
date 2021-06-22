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
    public partial class F_NovoUsuario : Form
    {
        public F_NovoUsuario()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            tb_nome.Clear();
            tb_senha.Clear();
            tb_userNamw.Clear();
            cb_status.Text = "";
            nup_nivel.Value = 0;
            tb_nome.Focus();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            Usuario ususario = new Usuario();
            ususario.nome = tb_nome.Text;
            ususario.usuario = tb_userNamw.Text;
            ususario.senha = tb_senha.Text;
            ususario.status = cb_status.Text;
            ususario.nivel =Convert.ToInt32(Math.Round(nup_nivel.Value));
            Banco.NovoUsuario(ususario);

            tb_nome.Clear();
            tb_senha.Clear();
            tb_userNamw.Clear();
            cb_status.Text = "";
            nup_nivel.Value = 0;


        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            tb_nome.Clear();
            tb_senha.Clear();
            tb_userNamw.Clear();
            cb_status.Text = "";
            nup_nivel.Value = 0;
            tb_nome.Focus();
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
