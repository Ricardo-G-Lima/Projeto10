using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PROJETO10.Models
{
    public class modelLogin
    {

        [Key]
        public int CODIGO { get; set; }

        public string USUARIO { get; set; }

        public string SENHA { get; set; }

    }
}