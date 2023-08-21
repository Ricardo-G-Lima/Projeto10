using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PROJETO10.Models
{
    public class modelLogin
    {

        [Key]
        public int CODIGO { get; set; }

        [DisplayName("Usúario")]
        [StringLength(50, ErrorMessage = "O nome deve conter no máx 50 caracteres")]
        [Required(ErrorMessage = " O campo Usúario é obrigatório")]
        public string USUARIO { get; set; }

        [DisplayName("Senha")]
        [StringLength(50, MinimumLength = 6, ErrorMessage ="A senha deve conter no máx 50 caracteres e no min 6")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage =" O campo Senha é obrigatório")]
        public string SENHA { get; set; }

    }
}