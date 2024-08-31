using System;
using System.Collections.ObjectModel;
using System.Linq;
using Microsoft.Maui.Controls;
using Modelos; 

namespace fluxo._2
{
    public partial class ProdutoPage : ContentPage
    {
        private ObservableCollection<Produto> produtos;
        private ObservableCollection<Produto> produtosFiltrados;

        public ProdutoPage()
        {
            InitializeComponent();

            // Inicialização dos produtos (substitua isso pelo carregamento real dos dados)
            produtos = new ObservableCollection<Produto>
            {
                new Produto { NomeDoProduto = "Produto A", Preço = 10 },
                new Produto { NomeDoProduto = "Produto B", Preço = 20 }
            };

            produtosFiltrados = new ObservableCollection<Produto>(produtos);
            ProdutosListView.ItemsSource = produtosFiltrados;
        }

        private void OnSearchBarTextChanged(object sender, TextChangedEventArgs e)
        {
            var searchText = e.NewTextValue?.ToLower();

            // Filtra a lista com base no texto da busca
            if (string.IsNullOrWhiteSpace(searchText))
            {
                ProdutosListView.ItemsSource = produtos;
            }
            else
            {
                ProdutosListView.ItemsSource = produtos.Where(p => p.NomeDoProduto.ToLower().Contains(searchText)).ToList();
            }
        }

        private void OnSearchClicked(object sender, EventArgs e)
        {
            // Adicione a lógica de busca aqui se necessário
        }

        private void OnAddProductClicked(object sender, EventArgs e)
        {
            // Adicione a lógica para adicionar um novo produto
        }

        private void OnAdicionarClicked(object sender, EventArgs e)
        {
            // Adicione a lógica para o botão "adicionar"
        }

        private void OnVoltarClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new MainPage();
        }

        private void OnProductSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var produtoSelecionado = e.SelectedItem as Produto;
            if (produtoSelecionado != null)
            {
                // Lógica para quando um produto for selecionado
            }
        }
    }
}
