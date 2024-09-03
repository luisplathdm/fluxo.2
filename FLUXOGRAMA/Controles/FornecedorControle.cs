using Modelos;

namespace Controles
{
    public class FornecedorControle : BaseControle
    {
        public FornecedorControle() : base()
        {
            NomeDaTabela = "Fornecedores";
        }

        public virtual Fornecedor? Ler(int idFornecedor)
        {
            var collection = liteDB.GetCollection<Fornecedor>(NomeDaTabela);
            return collection.FindOne(f => f.IdFornecedor == idFornecedor);
        }

        public virtual List<Fornecedor>? LerTodosagora()
        {
            var tabela = liteDB.GetCollection<Fornecedor>(NomeDaTabela);
            return new List<Fornecedor>(tabela.FindAll().OrderBy(f => f.CPFCNPJ).ToList()); 
            
        }

        public virtual void Apagar(int idFornecedor)
        {
            var collection = liteDB.GetCollection<Fornecedor>(NomeDaTabela);
            collection.Delete(idFornecedor);
        }

        public virtual void CriarOuAtualizarFornecedor(Fornecedor fornecedor)
        {
            var collection = liteDB.GetCollection<Fornecedor>(NomeDaTabela);
            collection.Upsert(fornecedor);
        }
    }
}
