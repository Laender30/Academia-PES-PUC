using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{

    [MetadataType(typeof(usuarioMetadado))]
    public partial class Usuario
    {
    }
     
        public class usuarioMetadado
    {

        [Required(ErrorMessage = "Obrigatório informar o Nome")]
        [StringLength(30, ErrorMessage = "O Nome deve possuir nomáximo 255 caracteres")]
public string Nome { get; set; }
        [Required(ErrorMessage = "Obrigatório informar o CPF")]
        [StringLength(80, ErrorMessage = "O Nome deve possuir no máximo 11 caracteres")]
        public string CPF { get; set; }
        [Required(ErrorMessage = "Obrigatório informar o Endereço")]
        [StringLength(100, ErrorMessage = "O Endereço deve possuir no  máximo 500 caracteres")]
        public string Endereco { get; set; }
        [Required(ErrorMessage = "Obrigatório informar o Tipo de Usuario")]
        [StringLength(60, ErrorMessage = "O Bairro deve possuir no máximo 1 caracteres")]
        public string TipoUsuario { get; set; }
        [Required(ErrorMessage = "Obrigatório informar o E-mail")]
        [StringLength(100, ErrorMessage = "O E-mail deve possuir no máximo 255 caracteres")]
        public string Email { get; set; }
 
    }
}