using LiteDB;

namespace Modelos;
public class Funcionario
{
  [BsonId]
   public int Idfuncionario  { get; set; }
   public int salario  { get; set; }
   public string cpf  { get; set; }
   public int idetapadeproducao { get; set; }
}