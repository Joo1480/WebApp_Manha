using Microsoft.EntityFrameworkCore;

namespace WebApp_Manha
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> opt)
        {

        }
    }
}
