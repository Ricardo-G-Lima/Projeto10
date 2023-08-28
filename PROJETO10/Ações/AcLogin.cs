using MySql.Data.MySqlClient;
using PROJETO10.DADOS;
using PROJETO10.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace PROJETO10.Ações
{
    public class AcLogin
    {
        conexao con = new conexao();
         public modelLogin TestarUsuario(modelLogin user)
         {
             MySqlCommand cmd = new MySqlCommand("select * from LOGIN where USUARIO = @USUARIO and SENHA = @SENHA",
                 con.MyConnectarBD());

             cmd.Parameters.Add("@USUARIO", MySqlDbType.VarChar).Value = user.USUARIO;
             cmd.Parameters.Add("@SENHA", MySqlDbType.VarChar).Value = user.SENHA;

            MySqlDataReader leitor;

            leitor = cmd.ExecuteReader();

            if(leitor.HasRows)
            {
                while(leitor.Read())
                {
                    modelLogin login = new modelLogin();
                    {
                        login.USUARIO = Convert.ToString(leitor["USUARIO"]);
                        login.SENHA = Convert.ToString(leitor["SENHA"]);

                    }

                }

            }
            else
            {
                user.USUARIO = null;
                user.SENHA = null;
            }


            con.MyDesconectarBD();
            return user;
             }
         

    }

}

