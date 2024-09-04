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
                IdCliente = c.IdCliente,
                Nome = c.Nome,
                cpf = c.cpf,
                Endereco = c.Endereco,
                Telefone = c.Telefone,
                DataDeNascimento = c.DataDeNascimento,
                Estado = c.Estado,

            }).ToList();

            ListaClientes.ItemsSource = clientesModelos;
        }

        void QuandoSelecionarUmItemNaLista(object sender, SelectedItemChangedEventArgs e)
        {
            var clienteSelecionado = e.SelectedItem as Modelos.Cliente; 
            if (clienteSelecionado != null)
            {
                var page = new CadastroPage
                {
                    cliente = clienteSelecionado 
                      

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
