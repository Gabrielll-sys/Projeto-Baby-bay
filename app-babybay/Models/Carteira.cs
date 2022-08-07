using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace app_babybay.Models
{
    [Table("Carteiras")]
    public class Carteira
    {
        [Key]
        public int Id { get; set; }

        public int UsuarioId { get; set; }
        [ForeignKey("UsuarioId")]
        public Usuario Usuario { get; set; }

        public int Saldo { get; private set; }

        public Carteira() 
        {  
            Saldo = 10;    
        }
 
        public void Receber(int quantidade)
        {
            Saldo += quantidade;
        }

        public bool Retirar(int quantidade)
        {
            if (quantidade < 0)
            {
                return false;
            }
            Saldo -= quantidade;
            return true;
        }        

        public void Transferir(int quantidade, Carteira carteiraDestino)
        {
            if (quantidade < 0)
            {
                return;
            }
            Retirar(quantidade);
            carteiraDestino.Receber(quantidade);
        }
    }
}
