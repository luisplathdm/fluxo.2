using System.Data;
using Controles;
using LiteDB;
namespace Modelos;

   //CLASSE FILHO//
  public class Cliente: Registro
    {
        [BsonId]
        public int IdCliente { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Telefone { get; set; }
        public string cpf { get; set; } // Propriedade cpf adicionada

    }