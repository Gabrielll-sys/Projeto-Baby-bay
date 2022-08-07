using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace app_babybay.Models
{
    [Table("Trocas")]
    public class Troca : Carteira
    {
        [Key]
        public new int Id { get; set; } // New oculta a implementação da classe base

        public int ProdutoId { get; set; }
        [ForeignKey("ProdutoId")]
        public Produto Produto { get; set; }

        public new int UsuarioId { get; set; }
        [ForeignKey("UsuarioId")]
        public new Usuario Usuario { get; set; }

        public DateTime Date { get; set; }
        /*  public ICollection<Produto> Produtos { get; set; }*/
      

    }
}
