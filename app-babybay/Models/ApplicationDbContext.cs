using Microsoft.EntityFrameworkCore;
using app_babybay.Models;

namespace app_babybay.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Carteira> Carteiras { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Troca> Trocas { get; set; }
    }
}
