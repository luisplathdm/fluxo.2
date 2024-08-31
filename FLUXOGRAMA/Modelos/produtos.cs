using LiteDB;

namespace Modelos
{
    public class Produto
    {
        [BsonId]
        public int IdProduto { get; set; }
        public int Preço { get; set; } 
        public string NomeDoProduto { get; set; } 
    }
}
