using LiteDB;

namespace Modelos;
public class Pedidos
{
      [BsonId]
    public int IdProduto { get; set; }
    public string NomeProduto{ get; set; }

}
