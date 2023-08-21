using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PROJETO10.DADOS
{
    public class conexao
    {
        MySqlConnection cn = new MySqlConnection("Server = Localhost; DataBase=BD; User=root; pwd=12345678 ");
        public static string msg;

        public MySqlConnection MyConnectarBD()
        {
            try
            {
                cn.Open();
            }
            catch (Exception erro)
            {
                msg = "Ocorreu um erro ao se conectar com o Banco de Dados" + erro.Message;
            }
            return cn;

        }
        public MySqlConnection MyDesconectarBD()
        {
            try
            {
                cn.Close();
            }
            catch (Exception erro)
            {
                msg = "Ocorreu um erro ao se Desconectar com o Banco de Dados" + erro.Message;
            }
            return cn;
        }
    }
}