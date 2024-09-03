using System;
using Microsoft.Maui.Controls;
using System.Threading.Tasks;
using Modelos;

namespace fluxo._2
{
    public partial class CadastroFornecedorPage : ContentPage
    {
        public Modelos.Fornecedor fornecedor { get; set; }
        Controles.FornecedorControle fornecedorControle = new Controles.FornecedorControle();

        public CadastroFornecedorPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (fornecedor != null)
            {
            
                NomeFornecedorEntry.Text = fornecedor.NomeFornecedor;
                TelefoneFornecedorEntry.Text = fornecedor.TelefoneFornecedor;
                EnderecoFornecedorEntry.Text = fornecedor.EnderecoFornecedor;
                CPFCNPJEntry.Text = fornecedor.CPFCNPJ;
            }
        }

        private async void QuandoSalvarForClicked(object sender, EventArgs e)
        {
            if (await VerificaSeDadosEstaoCorretos()) 
            {
                var fornecedor = new Modelos.Fornecedor();
                if (!String.IsNullOrEmpty(IdLabelFornecedor.Text))
                    fornecedor.IdFornecedor = int.Parse(IdLabelFornecedor.Text); 
                else
                    fornecedor.IdFornecedor = 0;

                fornecedor.CPFCNPJ = CPFCNPJEntry.Text;
               fornecedor.EnderecoFornecedor = EnderecoFornecedorEntry.Text;
               fornecedor.NomeFornecedor = NomeFornecedorEntry.Text; 
               fornecedor.TelefoneFornecedor = TelefoneFornecedorEntry.Text; 

                fornecedorControle.CriarOuAtualizarFornecedor(fornecedor);

                await DisplayAlert("Salvar", "Dados salvos com sucesso!", "OK");
            }
        }

          private async void ApagarFornecedorClicked (object sender, EventArgs e)
  {
    if (fornecedor == null || fornecedor.IdFornecedor < 1)
      await DisplayAlert("Erro", "Nenhum fornecedor para excluir", "ok");
    else if (await DisplayAlert("Excluir","Tem certeza que deseja excluir esse fornecedor?","Excluir fornecedor","cancelar")) // Caso o usuário tocar no Botão "Excluir Cliente"
    {
      
     fornecedorControle.Apagar(fornecedor.IdFornecedor);
      Application.Current.MainPage = new ListaFornecedorPage(); 
    }
  }

        private async Task<bool> VerificaSeDadosEstaoCorretos()
        {
           
            if (String.IsNullOrEmpty(NomeFornecedorEntry.Text))
            {
                await DisplayAlert("Cadastrar", "O campo Nome é obrigatório", "OK");
                return false;
            }
           
           
            else if (String.IsNullOrEmpty(TelefoneFornecedorEntry.Text))
            {
                await DisplayAlert("Cadastrar", "O campo Telefone é obrigatório", "OK");
                return false;
            }
            
            else if (String.IsNullOrEmpty(EnderecoFornecedorEntry.Text))
            {
                await DisplayAlert("Cadastrar", "O campo Endereço é obrigatório", "OK");
                return false;
            }
             else if (String.IsNullOrEmpty(CPFCNPJEntry.Text))
            {
                await DisplayAlert("Cadastrar", "O campo CPF é obrigatório", "OK");
                return false;
            }
            else
                return true;
        }

        private void VoltarClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new MainPage();
        }

        private void IrParaListagemDefornecedores(object sender, EventArgs e)
        {
            Application.Current.MainPage = new ListaFornecedorPage();
        }
    }
}
