using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;
using WebApp_Manha.Entidades;

namespace WebApp_Manha
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> opt) : base(opt) 
        {
            
        }

        public DbSet<Produtos> PRODUTOS { get; set; }
    }
}
