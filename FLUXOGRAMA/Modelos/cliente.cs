using System.Data;
using Controles;
using LiteDB;
namespace Modelos;

   //CLASSE FILHO//
  public class Cliente: Registro
    {
        [BsonId]
        public  new int IdCliente { get; set; }
        public new string Nome { get; set; }
        public new string Telefone { get; set; }
        public new string cpf { get; set; } // Propriedade cpf adicionada

    }