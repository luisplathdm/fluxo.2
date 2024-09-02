using Modelos;

namespace fluxo._2
{
    public partial class ListaFornecedorPage : ContentPage
    {
        Controles.FornecedorControle fornecedorControle = new Controles.FornecedorControle();

        public ListaFornecedorPage()
        {
            InitializeComponent();
            var fornecedoresFluxo = fornecedorControle.LerTodos();
            var fornecedoresModelos = fornecedoresFluxo.Select(c => new Modelos.Fornecedor
            {
                IdFornecedor = c.IdFornecedor,
                Nome = c.Nome,
                cpf = c.cpf,
                Endereco = c.Endereco,
                Telefone = c.Telefone,
                DataDeNascimento = c.DataDeNascimento,

            }).ToList();

            Listafornecedores.ItemsSource = fornecedoresModelos;
        }

        void QuandoSelecionarUmItemNaLista(object sender, SelectedItemChangedEventArgs e)
        {
            var fornecedorSelecionado = e.SelectedItem as Modelos.Fornecedor; 
            if (FornecedorSelecionado != null)
            {
                var page = new CadastroFornecedorPage
                {
                    fornecedor = fornecedorSelecionado 
                };

                Application.Current.MainPage = page;
            }
        }

        void NovoFornecedorClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new CadastroPage();
        }

        void VoltandoTudoNoInicio(object sender, EventArgs e)
        {
            Application.Current.MainPage = new MainPage();
        }
    }
}
