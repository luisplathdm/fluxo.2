using System;
using Microsoft.Maui.Controls;
using System.Threading.Tasks;

namespace fluxo._2
{
    public partial class CadastroPage : ContentPage
    {
        public Modelos.Cliente cliente { get; set; }
        Controles.ClienteControle clienteControle = new Controles.ClienteControle();
        Controles.EstadoControle estadoControle = new Controles.EstadoControle();


        public CadastroPage()
        {
            InitializeComponent();
               pickerEstado.ItemsSource = estadoControle.LerTodos();
               var estadosDoBanco = estadoControle.LerTodos();

    
                estadosDoBanco.Add(new Modelos.Estado { id = 4, Nome = "Baiti" });
                estadosDoBanco.Add(new Modelos.Estado { id = 5, Nome = "Apucarana(obvio)" });
                estadosDoBanco.Add(new Modelos.Estado { id = 6, Nome = "Compadre washgthon" });
                estadosDoBanco.Add(new Modelos.Estado { id = 7, Nome = "Arapongãs" });
                estadosDoBanco.Add(new Modelos.Estado { id = 8, Nome = "Não sei onde eu moro" });
                
                pickerEstado.ItemsSource = estadosDoBanco;

        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (cliente != null)
            {
                NomeEntry.Text = cliente.Nome;
                TelefoneEntry.Text = cliente.Telefone;
                EnderecoEntry.Text = cliente.Endereco;
                cpfEntry.Text = cliente.cpf; 
                DataDeNascimentoEntry.Text = cliente.DataDeNascimento;
                pickerEstado.SelectedItem = cliente.Estado;
            }
        }

        private async void OnSalvarClicked(object sender, EventArgs e)
        {
            if (await VerificaSeDadosEstaoCorretos()) 
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
               cliente.DataDeNascimento = DataDeNascimentoEntry.Text;

                clienteControle.CriarOuAtualizar(cliente);

                await DisplayAlert("Salvar", "Dados salvos com sucesso!", "OK");
            }
        }

          private async void OnApagarClienteClicked(object sender, EventArgs e)
  {
    if (cliente == null || cliente.IdCliente < 1)
      await DisplayAlert("Erro", "Nenhum cliente para excluir", "ok");
    else if (await DisplayAlert("Excluir","Tem certeza que deseja excluir esse cliente?","Excluir Cliente","cancelar")) // Caso o usuário tocar no Botão "Excluir Cliente"
    {
      
      clienteControle.Apagar(cliente.IdCliente);
      Application.Current.MainPage = new ListaClientePage(); 
    }
  }

        private async Task<bool> VerificaSeDadosEstaoCorretos()
        {
           
            if (String.IsNullOrEmpty(NomeEntry.Text))
            {
                await DisplayAlert("Cadastrar", "O campo Nome é obrigatório", "OK");
                return false;
            }
           
            else if (String.IsNullOrEmpty(DataDeNascimentoEntry.Text))
            {
                await DisplayAlert("Cadastrar", "O campo Data De Nascimento é obrigatório", "OK");
                return false;
            }
           
            else if (String.IsNullOrEmpty(TelefoneEntry.Text))
            {
                await DisplayAlert("Cadastrar", "O campo Telefone é obrigatório", "OK");
                return false;
            }
            
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
