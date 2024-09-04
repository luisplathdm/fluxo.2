using System.Data;
using Controles;
using LiteDB;

namespace Modelos;

public class Estado : Registro
{
  [BsonId]
  public  int id { get; set; }
  public  string Nome {get; set ;}
}