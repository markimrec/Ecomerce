using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyEcomerce.Models
{
    public class Usuario
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Senha { get; set; }

        private string _nomeDaMae;
        public string NomeDaMae
        {
            get { return _nomeDaMae;  }
            set { _nomeDaMae = value; }
        }

    }
}
