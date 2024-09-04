using System.Data;
using Controles;
using LiteDB;
namespace Modelos;

  
  public class Cliente: Registro
    {
        [BsonId]
        public  int IdCliente { get; set; }
        public  string Nome { get; set; }
        public  string Endereco { get; set; } 
        public  string Telefone { get; set; } 
        public  string cpf { get; set; } 
         public  string DataDeNascimento{ get; set; } 
         public Estado Estado { get; set; }

    }