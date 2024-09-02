using Modelos;

namespace Controles
{
    public class FornecedorControle : BaseControle
    {
        public FornecedorControle() : base()
        {
            NomeDaTabela = "Fornecedor";
        }

        public virtual Fornecedor? Ler(int idFornecedor)
        {
            var collection = liteDB.GetCollection<Fornecedor>(NomeDaTabela);
            return collection.FindOne(d => d.IdFornecedor == IdFornecedor);
        }

        public virtual List<Fornecedor>? LerTodos()
        {
            var tabela = liteDB.GetCollection<Fornecedor>(NomeDaTabela);
            return new List<Fornecedor>(tabela.FindAll().OrderBy(d => d.cpf)); 
        }

        public virtual void Apagar(int idFornecedor)
        {
            var collection = liteDB.GetCollection<Fornecedor>(NomeDaTabela);
            collection.Delete(IdFornecedor);
        }

        public virtual void CriarOuAtualizar(Fornecedor fornecedor)
        {
            var collection = liteDB.GetCollection<Fornecedor>(NomeDaTabela);
            collection.Upsert(fornecedor);
        }
    }
}
