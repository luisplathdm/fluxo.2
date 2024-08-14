using LiteDB;

namespace Modelos;
public class Produto
{
     [BsonId]

    public int IdProduto{ get; set; }
    public string cnpj{ get; set; }

}