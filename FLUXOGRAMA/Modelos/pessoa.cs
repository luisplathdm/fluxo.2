using System.Data;
using LiteDB;
namespace Modelos;
 
 //CLASSE PAI//

 public class Pessoa
{
    [BsonId]
 public int IdPessoa{ get; set; }
 public string nome{ get; set; }
 public string telefone{ get; set; }
 public string cidade{ get; set; }
 public string municipio{ get; set; }
 public string uf{ get; set; }
 public DateTime dn{ get; set; }
}