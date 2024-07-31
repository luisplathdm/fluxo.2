using System.Data;
namespace Modelos;
 
 //CLASSE PAI//

 public class Pessoa
{
 protected int id;
 protected string nome;
 protected string telefone;
 protected string cidade;
 protected string municipio;
 protected string uf;
 protected DateTime dn;

 public void SetID (int NumeroDeIndentificacao)
 {
  id = id;
 }
 
 public void GetID()
 {
   return id;
 }

 public void SetNome (string NomeDaPessoa)
 {
   nome = NomeDaPessoa;
 }

 public string GetNome()
 {
    return nome;
 }

 public void SetTelefone (string telefone)
 {
  this.telefone = telefone;
 }

 public string GetTelefone()
 {
   return telefone;
 }

 public void SteCidade (string cidade)
 {
   this.cidade = cidade;
 }

 public string GetCidade()
 {
   return cidade;
 }
  public void SetMunicipio (string municipio)
  {
    this.municipio = municipio;
  }

  public string GetMunicipio()
  {
    return municipio;
  }
}