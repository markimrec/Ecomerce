using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace MyEcomerce.Models
{
    public class Produto
    {
        [DisplayName("Número de Identificação do Fornecedor")]
        public int Id { get; set; }
        public string Name { get; set; }
        public int IdFornecedor { get; set; }

    }
}
