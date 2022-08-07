using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace app_babybay.Models
{
    [Table("Produtos")]
    public class Produto
    {
        // GUARDA ROUPAS VAI ENTRAR COMO METODO
        [Key]
        public int Id { get; set; }

        public int UsuarioId { get; set; }
        [ForeignKey("UsuarioId")]
        public Usuario Usuario { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "A cor é obrigatória.")]
        public string Cor { get; set; }

        [Display(Name = "Idade da Criança")]
        [Required(ErrorMessage = "A idade é obrigatória.")]
        public int Idade { get; set; }

        [Display(Name = "Tempo de Uso em Meses")]
        [Required(ErrorMessage = "O tempo de uso é obrigatório.")]
        public int TempoUso { get; set; }

        [Display(Name = "Descrição do Produto")]
        [Required(ErrorMessage = "Favor inserir uma descrição do produto."), MaxLength(120)]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "O tamanho é obrigatório")]
        public int Tamanho { get; set; }

        [Required(ErrorMessage = "A categoria é obrigatória.")]
        public Categoria Categoria { get; set; }

            
    }

    public enum Categoria
    {
        Camiseta,
        Short,
        Calça,
        Macacão,
        Calçado,
        Outros
    }
}

