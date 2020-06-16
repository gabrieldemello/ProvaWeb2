using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProvaWeb2.Models
{
    public class Pessoa
    {
        [Key]
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Sexo { get; set; }
        public string Endereco { get; set; }
        public int DataNasc { get; set; }
        public int CarteraTrab { get; set; }
        public int Tel { get; set; }
        public int Cel { get; set; }
        public string Email { get; set; }
    }
}