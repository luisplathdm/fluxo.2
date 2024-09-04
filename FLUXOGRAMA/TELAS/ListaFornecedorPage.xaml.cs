using Modelos;

namespace fluxo._2
{
    public partial class ListaFornecedorPage : ContentPage
    {
        Controles.FornecedorControle fornecedorControle = new Controles.FornecedorControle();

        public ListaFornecedorPage()
        {
            InitializeComponent();
            ListaFornecedor.ItemsSource = fornecedorControle.LerTodos();
        }

        void QuandoSelecionarUmItemNaLista(object sender, SelectedItemChangedEventArgs e)
        {
           var page = new CadastroFornecedorPage();
   
           page.fornecedor = e.SelectedItem as Fornecedor;
    
            Application.Current.MainPage = page;
  
            
        }

        void NovoFornecedorClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new CadastroFornecedorPage();
        }

        void VoltandoTudoNoInicio(object sender, EventArgs e)
        {
            Application.Current.MainPage = new MainPage();
        }
    }
}   

