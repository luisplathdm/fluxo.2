using System.Data;
using Controles;
using LiteDB;
namespace Modelos;

   //CLASSE FILHO//
  public class Cliente: Registro
    {
        [BsonId]
        public  new int IdCliente { get; set; } // Propriedade Identificação Do Cliente
        public new string Nome { get; set; }
        public new string Endereco { get; set; } // Propriedade Nome 
        public new string Telefone { get; set; } // Propriedade Telefone
        public new string cpf { get; set; } // Propriedade cpf 

    }