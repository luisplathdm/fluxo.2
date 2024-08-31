using System.Data;
using Controles;
using LiteDB;
namespace Modelos;

   //CLASSE FILHO//
  public class Cliente: Registro
    {
        [BsonId]
        public  int IdCliente { get; set; } // Propriedade Identificação Do Cliente
        public  string Nome { get; set; }
        public  string Endereco { get; set; } // Propriedade Nome 
        public  string Telefone { get; set; } // Propriedade Telefone
        public  string cpf { get; set; } // Propriedade cpf
         public  string DataDeNascimento{ get; set; } // Propriedade Data de nascimento

    }