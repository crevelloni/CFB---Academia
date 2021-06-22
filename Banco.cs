using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace CFB___Academia
{
    class Banco
    {
        private static SQLiteConnection conexao;
        private static SQLiteConnection ConexaoBanco()
        {
            try
            {
                conexao = new SQLiteConnection("Data Source="+ Globais.caminhoBanco + Globais.nomeBanco);
                conexao.Open();
                return conexao;
            }
            catch(Exception ex)
            {
                throw ex;
            }
           
        }
        public static DataTable GetUsers()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                {
                    cmd.CommandText = "select * from tb_usuario";
                    da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                    da.Fill(dt);
                    vcon.Close();
                    return dt;
                }
            }
            catch(Exception ex)
            {          
                throw ex;
            }
        }
        public static DataTable GetUsersIdNome()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                {
                    cmd.CommandText = "select N_Id_Usuario as 'Id Usuário',T_NomeUsuario as 'Nome Usuário' from tb_usuario";
                    da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                    da.Fill(dt);
                    vcon.Close();
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static DataTable GetUsersData(string id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                {
                    cmd.CommandText = "select * from tb_usuario where N_Id_Usuario="+id;
                    da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                    da.Fill(dt);
                    vcon.Close();
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void UpdateUser(Usuario u)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                {
                    cmd.CommandText = "update tb_usuario set T_NomeUsuario='"+u.nome +"',T_userName='"+u.usuario+"',T_Senha='"+u.senha +"',T_StatusUsuario='"+u.status+ "',N_NivelUsuario=" +u.nivel+" WHERE N_Id_Usuario="+u.id; 
                    da = new SQLiteDataAdapter(cmd.CommandText, vcon);                 
                    cmd.ExecuteNonQuery();
                    vcon.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void InativarUser(string id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                {
                    cmd.CommandText = "delete from tb_usuario where N_Id_Usuario="+id;
                    da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                    cmd.ExecuteNonQuery();
                    vcon.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static DataTable DQL(string sql)//data query language -- select
        {
            SQLiteDataAdapter da = null; 
            DataTable dt = new DataTable();

            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                {
                    cmd.CommandText = sql;
                    da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                    da.Fill(dt);
                    vcon.Close();
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void DML(string q, string msgOK=null,string msgERRO=null)//data manipulation language -- insert,delete,update
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                {
                    cmd.CommandText = q;
                    da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                    cmd.ExecuteNonQuery();
                    vcon.Close();
                    if (msgOK != null)
                    {
                        MessageBox.Show(msgOK);
                    }
                }
            }
            catch (Exception ex)
            {
                if(msgERRO != null)
                {
                    MessageBox.Show(msgERRO + "\n" + ex.Message);
                }
                throw ex;
            }
        }
        public static void NovoUsuario(Usuario u)
        {
            if (existeUsername(u))
            {
                MessageBox.Show("Username já existe");
                return;
            }
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "insert into tb_usuario (T_NomeUsuario,T_userName,T_Senha,T_StatusUsuario,N_NivelUsuario)values(@nome,@username,@senha,@statusUsuario,@nivel)";
                cmd.Parameters.AddWithValue("@nome", u.nome);
                cmd.Parameters.AddWithValue("@username", u.usuario);
                cmd.Parameters.AddWithValue("@senha", u.senha);
                cmd.Parameters.AddWithValue("@statusUsuario", u.status);
                cmd.Parameters.AddWithValue("@nivel", u.nivel);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Usuário inserido com sucesso");
                vcon.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao gravar usuário");               
            }

        }
        public static bool existeUsername(Usuario u)
        {
            bool res;
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            var vcon = ConexaoBanco();
            var cmd = vcon.CreateCommand();
            cmd.CommandText = "select T_userName from tb_usuario where T_UserName='" + u.usuario + "'";
            da = new SQLiteDataAdapter(cmd.CommandText, vcon);
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }
    }
}
