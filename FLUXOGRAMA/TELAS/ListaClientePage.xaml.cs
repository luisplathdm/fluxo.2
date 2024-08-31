using Modelos;

namespace fluxo._2
{
    public partial class ListaClientePage : ContentPage
    {
        Controles.ClienteControle clienteControle = new Controles.ClienteControle();

        public ListaClientePage()
        {
            InitializeComponent();
            var clientesFluxo = clienteControle.LerTodos();
            var clientesModelos = clientesFluxo.Select(c => new Modelos.Cliente
            {
                Nome = c.Nome,
                Idade = c.Idade,
                // Continue com as outras propriedades
            }).ToList();

            ListaClientes.ItemsSource = clientesModelos;
        }

        void QuandoSelecionarUmItemNaLista(object sender, SelectedItemChangedEventArgs e)
        {
            var clienteSelecionado = e.SelectedItem as Modelos.Cliente; // Referenciando Modelos.Cliente
            if (clienteSelecionado != null)
            {
                var page = new CadastroPage
                {
                    cliente = clienteSelecionado // Certifique-se de que CadastroPage usa o mesmo tipo Cliente
                };

                Application.Current.MainPage = page;
            }
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
}
