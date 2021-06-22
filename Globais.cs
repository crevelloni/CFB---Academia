using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFB___Academia
{
    class Globais
    {
        public static string versao = "1.0";
        public static bool logado = false;
        public static int nivel = 0;//1- usuario comum, 2- gerete, 3- master
        //public static string caminho = System.Environment.CurrentDirectory;
        public static string caminho = System.AppDomain.CurrentDomain.BaseDirectory.ToString();
        public static string nomeBanco = "db_academia.db";
        public static string caminhoBanco = caminho + @"\banco\";
        public static string caminhoFotos = caminho + @"\fotos\";

        /*
        N_Id_Usuario
        T_NomeUsuario
        T_userName
        T_Senha
        T_StatusUsuario
        N_NivelUsuario    
         */
    }
}
