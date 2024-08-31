using System;
using System.Collections.ObjectModel;
using System.Linq;
using Microsoft.Maui.Controls;
using Modelos;

namespace fluxo._2
{
    public partial class BuscaDeCliente : ContentPage
    {
        private ObservableCollection<Cliente> clientes;
        private ObservableCollection<Cliente> clientesFiltrados;

        public BuscaDeCliente()
        {
            InitializeComponent();

            // Inicialize a lista de clientes (substitua isso pelo carregamento real dos dados)
            clientes = new ObservableCollection<Cliente>
            {
                new Cliente { Nome = "Cliente A" },
                new Cliente { Nome = "Cliente B" }
                // Adicione outros clientes conforme necessário
            };

            clientesFiltrados = new ObservableCollection<Cliente>(clientes);
            ClientesListView.ItemsSource = clientesFiltrados;
        }

        private void OnSearchBarTextChanged(object sender, TextChangedEventArgs e)
        {
            var searchText = e.NewTextValue?.ToLower();

            if (string.IsNullOrWhiteSpace(searchText))
            {
                ClientesListView.ItemsSource = clientes;
            }
            else
            {
                ClientesListView.ItemsSource = clientes.Where(c => c.Nome.ToLower().Contains(searchText)).ToList();
            }
        }

        private void OnSearchClicked(object sender, EventArgs e)
        {
            // Adicione a lógica de busca aqui se necessário
        }

        private void AdicionarClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new CadastroPage();
        }

        private void OnVoltarClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new MainPage();
        }

        private void OnProductSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var clienteSelecionado = e.SelectedItem as Cliente;
            if (clienteSelecionado != null)
            {
                // Lógica para quando um cliente for selecionado
            }
        }
    }

    public class Cliente
    {
        public string Nome { get; set; }
    }
}
