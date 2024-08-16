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
}


