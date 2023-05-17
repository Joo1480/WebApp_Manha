using WebApp_Manha.Entidades;

namespace WebApp_Manha.Models
{
    public class NovoProdutoModel
    {
        public NovoProdutoModel() 
        {
            ListaCategorias = new List<Categorias>();
        }
        public List<Categorias> ListaCategorias { get; set; }
    }
}
