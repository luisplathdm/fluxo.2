using System;
using Microsoft.Maui.Controls;

namespace fluxo._2
{
    public partial class ProdutoPage : ContentPage
    {
        public ProdutoPage()
        {
            InitializeComponent();
        }
        private void OnSearchClicked(object sender, EventArgs e)
        {
            // Adicione a lógica de busca aqui
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
            Application.Current.MainPage= new MainPage();
        }
    }
}
