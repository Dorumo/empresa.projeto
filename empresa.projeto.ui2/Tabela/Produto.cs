using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace empresa.projeto.ui2.Tabela
{
    public class Produto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Informe o nome")]
        [StringLength(50)]
        public string Nome { get; set; }

        [DataType(DataType.Date)]        
        public DateTime DataValidade { get; set; }

        [DataType(DataType.Currency)]
        public decimal Valor { get; set; }
    }
}
