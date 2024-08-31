using System;
using Microsoft.Maui.Controls;
using System.Threading.Tasks;

namespace fluxo._2
{
    public partial class CadastroPage : ContentPage
    {
        public Modelos.Cliente cliente { get; set; }
        Controles.ClienteControle clienteControle = new Controles.ClienteControle();

        public CadastroPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (cliente != null)
            {
                // Preenche os campos com os dados do cliente existente
                NomeEntry.Text = cliente.Nome;
                TelefoneEntry.Text = cliente.Telefone;
                EnderecoEntry.Text = cliente.Endereco;
                cpfEntry.Text = cliente.cpf; 
                
            }
        }

        private async void OnSalvarClicked(object sender, EventArgs e)
        {
            if (await VerificaSeDadosEstaoCorretos()) // Verifica se Todos os dados são válidos antes de salvar no banco
            {
                var cliente = new Modelos.Cliente();
                if (!String.IsNullOrEmpty(IdLabel.Text))
                    cliente.IdCliente = int.Parse(IdLabel.Text); 
                else
                    cliente.IdCliente = 0;

                cliente.Nome = NomeEntry.Text;
                cliente.Endereco = EnderecoEntry.Text;
                cliente.cpf = cpfEntry.Text; 
                cliente.Telefone = TelefoneEntry.Text; 
               cliente.DataDeNascimento = (DataDeNascimentoEntry.Text);


                // Cria ou atualiza o cliente
                clienteControle.CriarOuAtualizar(cliente);

                await DisplayAlert("Salvar", "Dados salvos com sucesso!", "OK");
            }
        }

          private async void OnApagarClienteClicked(object sender, EventArgs e)
  {
    // Verifica se estamos editando um cliente ou criando um cliente
    // Se estiver criando, não se pode apagar, já que não se tem um `cliente.Id`
    if (cliente == null || cliente.IdCliente < 1)
      await DisplayAlert("Erro", "Nenhum cliente para excluir", "ok");
    else if (await DisplayAlert("Excluir","Tem certeza que deseja excluir esse cliente?","Excluir Cliente","cancelar")) // Caso o usuário tocar no Botão "Excluir Cliente"
    {
      // Apaga do Banco de Dados
      clienteControle.Apagar(cliente.IdCliente);
      // Volta para a tela de Lista
      // Esse código abaixo pode ser um:
      // await NavigationPage.PopAsync();
      // Se você veio pra cá com um 
      // await Navigation.PushAsync(new CadastroClientePage);
      Application.Current.MainPage = new ListaClientePage(); 
    }
  }

        private async Task<bool> VerificaSeDadosEstaoCorretos()
        {
            // Verifica se a Entry do Nome está vazia
            if (String.IsNullOrEmpty(NomeEntry.Text))
            {
                await DisplayAlert("Cadastrar", "O campo Nome é obrigatório", "OK");
                return false;
            }
            // Verifica se a Entry do CPF está vazia
            else if (String.IsNullOrEmpty(DataDeNascimentoEntry.Text))
            {
                await DisplayAlert("Cadastrar", "O campo Data De Nascimento é obrigatório", "OK");
                return false;
            }
            // Verifica se a Entry do Telefone está vazia
            else if (String.IsNullOrEmpty(TelefoneEntry.Text))
            {
                await DisplayAlert("Cadastrar", "O campo Telefone é obrigatório", "OK");
                return false;
            }
            // Verifica se a Entry do Endereço está vazia
            else if (String.IsNullOrEmpty(EnderecoEntry.Text))
            {
                await DisplayAlert("Cadastrar", "O campo Endereço é obrigatório", "OK");
                return false;
            }
             else if (String.IsNullOrEmpty(cpfEntry.Text))
            {
                await DisplayAlert("Cadastrar", "O campo CPF é obrigatório", "OK");
                return false;
            }
            else
                return true;
        }

        private void OnVoltarClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new MainPage();
        }

        private void IrParaListagemDeClientes(object sender, EventArgs e)
        {
            Application.Current.MainPage = new ListaClientePage();
        }
    }
}
