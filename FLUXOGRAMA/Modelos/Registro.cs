using LiteDB;

namespace Controles;
public class Registro
{
 [BsonId]
        public   int IdCliente { get; set; }
        public string Nome { get; set; }
        public  string Telefone { get; set; }
        public  string cpf { get; set; }
} 