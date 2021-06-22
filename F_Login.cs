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
    public partial class F_Login : Form
    {
        Form1 form1;
        DataTable dt = new DataTable();
        public F_Login(Form1 f)
        {
            InitializeComponent();
            form1 = f;
        }

        private void btn_logar_Click(object sender, EventArgs e)
        {
            try
            {
                string username = tb_username.Text;
                string senha = tb_senha.Text;
                if (username == "" || senha == "")
                {
                    MessageBox.Show("Usuário e/ou senha inválidos");
                    tb_username.Focus();
                    return;
                }
                string sql = "select * from tb_usuario where T_userName='" + username + "' AND T_Senha='" + senha +"'";
                dt = Banco.DQL(sql);
                if (dt.Rows.Count == 1)
                {
                    form1.lb_num_acesso.Text = dt.Rows[0].ItemArray[5].ToString();
                    form1.lb_nomeUsuario.Text = dt.Rows[0].Field<string>("T_NomeUsuario");
                    form1.pb_ledLOgado.Image = Properties.Resources.verde;
                    Globais.nivel = int.Parse(dt.Rows[0].Field<Int64>("N_NivelUsuario").ToString());
                    Globais.logado = true;
                    this.Close();
                }
                else
                {

                    MessageBox.Show("Usuário não encontrado");
                }
            }catch(Exception ex)
            {
                throw ex;
            }
            
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
