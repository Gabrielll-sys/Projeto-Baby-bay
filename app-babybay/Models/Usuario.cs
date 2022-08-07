using app_babybay.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace app_babybay.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        public  int Id { get; set; }

        /* Dados pessoais */
        [Display(Name = "Nome Completo")]
        [Required(ErrorMessage = "Favor informar o nome.")]
        [MinLength(3)]
        public string Nome { get; set; }

        [Display(Name = "Data de Nascimento")]
        [Required(ErrorMessage = "Favor informar a data de nascimento.")]
        public DateTime DataNascimento { get; set; }

        [Display(Name = "CPF")]
        [MaxLength(11), MinLength(11)]
        [Required(ErrorMessage = "Favor informar o CPF.")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "Favor informar o telefone.")]
        public string Telefone { get; set; }

        /* Endereço */
        [Required(ErrorMessage = "Favor informar a rua.")]
        public string Rua { get; set; }
        [Required(ErrorMessage = "Favor informar o bairro.")]
        public string Bairro { get; set; }
        [Required(ErrorMessage = "Favor informar a cidade.")]
        public string Cidade { get; set; }
        [Required(ErrorMessage = "Favor informar o estado.")]
        public Estado Estado { get; set; }

        /* Login */
        [Display(Name = "E-mail")]
        [Required(ErrorMessage = "Favor informar o email.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Favor informar a senha.")]
        [MinLength(8)]     
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Favor confirmar a senha.")]
        [MinLength(8)]
        [DataType(DataType.Password)]
        public string ConfirmarSenha { get; set; }
   
        /* Navegação */
        public ICollection<Produto> Produtos { get; set; }     
        public ICollection<Troca> Trocas { get; set; }

        // Instância de Carteira para passar ao UsuariosController 
        public Carteira CriarCarteira()
        {
            Carteira carteira = new Carteira();           
            return carteira;
        }
    }

    public enum Estado
    {
        Selecionar, 
        AC,
        AL,
        AP,
        AM,
        BA,
        CE,
        ES,
        DF,
        GO,
        MA,
        MT,
        MS,
        MG,
        PA,
        PB,
        PR,
        PE,
        PI,
        RJ,
        RN,
        RS,
        RO,
        RR,
        SC,
        SP,
        SE,
        TO       
    }
}