using System;
using Microsoft.Maui.Controls;

namespace fluxo._2
{
    public partial class CadastroPage : ContentPage
    {
        public Modelos.Cliente Cliente { get; set; }
        Controles.ClienteControle clienteControle = new Controles.ClienteControle();

        public CadastroPage()
        {
            InitializeComponent();
        }

        private async void OnSalvarClicked(object sender, EventArgs e)
        {
            if (await VerificaSeDadosEstaoCorretos()) // Verifica se os dados são válidos antes de salvar no banco
            {
                var cliente = new Modelos.Cliente();
                if (!String.IsNullOrEmpty(IdLabel.Text))
                    cliente.IdCliente = int.Parse(IdLabel.Text); // Propriedade IdCliente agora existe
                else
                    cliente.IdCliente = 0;

                cliente.Nome = NomeEntry.Text; // Propriedade Nome agora existe
                cliente.Sobrenome = SobrenomeEntry.Text; // Propriedade Sobrenome agora existe
                cliente.Telefone = TelefoneEntry.Text; // Propriedade Telefone agora existe

                clienteControle.CriarOuAtualizar(cliente);

                await DisplayAlert("Salvar", "Dados salvos com sucesso!", "OK");
            }
        }

        private Task<bool> VerificaSeDadosEstaoCorretos()
        {
            // Implemente a lógica de verificação aqui
            return Task.FromResult(true);
        }

        private void OnVoltarClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new MainPage();
        }
    }
}
