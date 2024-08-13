using System.Data;
using Controles;
using LiteDB;
namespace Modelos;

   //CLASSE FILHO//
  public class Cliente: Registro
    {
        [BsonId]
      public int IdCliente { get; set; }
      public string cpf  { get; set; }
    }