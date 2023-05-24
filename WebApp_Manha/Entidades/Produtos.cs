namespace WebApp_Manha.Entidades
{
    public class Produtos
    {
        public int ID { get; set; }
        public string DESCRICAO { get; set;}
        public decimal VALOR { get; set;}
        public bool ATIVO { get; set;}
        public int CATEGORIAID { get; set;}
        public Categorias CATEGORIA { get; set;}
    }
}
