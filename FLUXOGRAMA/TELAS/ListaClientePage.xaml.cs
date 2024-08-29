using LiteDB;
using Modelos;
namespace fluxo._2;
public partial class ListaClientePage : ContentPage
{
  Controles.ClienteControle clienteControle = new Controles.ClienteControle();

  public ListaClientePage()
	{
		InitializeComponent();
       ListaClientes.ItemsSource = clienteControle.LerTodos();
	}

  void QuandoSelecionarUmItemNaLista(object sender, SelectedItemChangedEventArgs e)
  {
    
    var page = new CadastroPage();
    // O passo seguinte é dizer para nova página qual cliente foi selecionado. Olhe o código da CadastroClientePage,
    // e verifique que lá terá um atributo público do tipo Cliente, chamado cliente.
    // Toda vez que se clica em um cliente na lista nessa página, setaremos na CadastroClientePage o atributo cliente 
    // com o cliente que foi clicado aqui.
    page.cliente = e.SelectedItem as Cliente;
    // Troca-se a página principal para a página que acabamos de criar
    Application.Current.MainPage = page;
  }

  void NovoClienteClicked(object sender, EventArgs e)
  {
    Application.Current.MainPage = new CadastroPage();
  }
  void VoltandoTudoAoInicio(object sender, EventArgs e)
  {
    Application.Current.MainPage = new MainPage();
  }
}