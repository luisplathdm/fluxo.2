
using Controles;
using LiteDB;

namespace Modelos;
public class Fornecedor: Registro
{
      [BsonId]

    public int IdFornecedor   { get; set; }
    public string NomeFornecedor  { get; set; }
    public string TelefoneFornecedor  { get; set; }
    public string EnderecoFornecedor  { get; set; }
    public string CPFCNPJ  { get; set; }

}

