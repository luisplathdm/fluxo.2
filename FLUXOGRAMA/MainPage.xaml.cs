namespace fluxo._2;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}
 private void comecando(object sender, EventArgs e)
        {
          Application.Current.MainPage = new BuscaDeCliente();        
		}
		 private void OnClienteClicked(object sender, EventArgs e)
        {
			Application.Current.MainPage = new CadastroPage();              }

        private void OnProdutoClicked(object sender, EventArgs e)
        {
			Application.Current.MainPage = new ProdutoPage();              }

        private void OnFornecedorClicked(object sender, EventArgs e)
        {
			Application.Current.MainPage = new BuscaDeCliente();              }

        private void OnBuscaClicked(object sender, EventArgs e)
        {
			Application.Current.MainPage = new BuscaDeCliente();          
	    }
}


