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
            
        }

        private void OnAddProductClicked(object sender, EventArgs e)
        {
           
        }

        private void OnAdicionarClicked(object sender, EventArgs e)
        {
            
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
                
            }
        }
    }
}
