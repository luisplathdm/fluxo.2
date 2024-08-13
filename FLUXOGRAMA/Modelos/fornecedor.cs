
using LiteDB;

namespace Modelos;
public class FornecedorMateriaPrima
{
      [BsonId]

    public int IdFornecedor   { get; set; }
    public string NomeFornecedor  { get; set; }
}
