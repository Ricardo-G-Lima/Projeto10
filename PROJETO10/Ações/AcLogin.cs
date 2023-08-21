using MySql.Data.MySqlClient;
using PROJETO10.DADOS;
using PROJETO10.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PROJETO10.Ações
{
    public class AcLogin
    {
        conexao con = new conexao();
        /* public void usuarios(modelLogin modelLogin)
         {
             MySqlCommand cmd = new MySqlCommand("insert into LOGIN(USUARIO,SENHA) values (@USUARIO,@SENHA)",
                 con.MyConnectarBD());

             cmd.Parameters.Add("@USUARIO", MySqlDbType.VarChar).Value = modelLogin.USUARIO;
             cmd.Parameters.Add("@SENHA", MySqlDbType.VarChar).Value = modelLogin.SENHA;

             cmd.ExecuteNonQuery();
             con.MyDesconectarBD();
             }
         }*/

        public void usuarios()
        {
            modelLogin mod = new modelLogin();

            List<SelectListItem> usuarios = new List<SelectListItem>();
            {

                MySqlCommand cmd = new MySqlCommand("select * from LOGIN where USUARIO = '@USUARIO' and SENHA = '@SENHA'", con.MyConnectarBD());
                MySqlDataReader rdr = cmd.ExecuteReader();

                rdr.Read();

                mod.USUARIO = rdr["USUARIO"].ToString();
                mod.SENHA = rdr["SENHA"].ToString();

                rdr.Close();
                con.MyDesconectarBD();

            }


        }

    }

}

