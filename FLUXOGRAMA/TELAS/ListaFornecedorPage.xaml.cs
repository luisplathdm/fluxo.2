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
            var fornecedorSelecionado = e.SelectedItem as Modelos.Fornecedor; 
            if (fornecedorSelecionado != null)
            {
                var page = new CadastroFornecedorPage
                page.cliente = e.SelectedItem as Cliente;
                {
                    fornecedor = fornecedorSelecionado 
                };

                Application.Current.MainPage = page;
            }
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
