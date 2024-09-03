using System.Data;
using LiteDB;
namespace Modelos;
 
 //CLASSE PAI//

 public class Pessoa
{
    [BsonId]
 public int Id { get; set; }
 public string Nome{ get; set; }
 public string Telefone{ get; set; }
 public string Cidade{ get; set; }
 public string Municipio{ get; set; }
 public string Uf{ get; set; }
 public DateTime Dn{ get; set; }
}