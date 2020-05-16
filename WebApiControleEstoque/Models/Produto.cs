using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiControleEstoque.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal Quantidade { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal Valor { get; set; }

        public int GrupoId { get; set; }

        public Grupo Grupo { get; set; }
    }
}
