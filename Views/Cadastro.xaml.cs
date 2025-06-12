namespace BreakCar.Views;
using BreakCar.Controllers;
using BreakCar.Models;
using BreakCar.Services;

public partial class Cadastro : ContentPage
{
    private CarroController carroController;
	public Cadastro()
	{
		InitializeComponent();

        carroController = new CarroController();
	}

    string sImagemSelecionada;
    private async void btnSelecionar_Clicked(object sender, EventArgs e)
    {
        sImagemSelecionada = await ImageService.SelecionarImagem();
        if (!string.IsNullOrEmpty(sImagemSelecionada))
        {
            imgSelecionada.Source = sImagemSelecionada;

            // Mostra o botão Remover e esconde o Selecionar
            btnRemover.IsVisible = true;
            btnSelecionar.IsVisible = false;
        }
    }

    private void btnAdicionar_Clicked(object sender, EventArgs e)
    {
        string placa = txtPlaca.Text;
        string marca = txtMarca.Text;
        string modelo = txtModelo.Text;
        string cor = txtCor.Text;
        string nomeProprietario = txtNomeProprietario.Text;
        string tipo = pckTipo.SelectedItem?.ToString();

        if (string.IsNullOrEmpty(placa) || string.IsNullOrEmpty(marca) ||
            string.IsNullOrEmpty(modelo) || string.IsNullOrEmpty(cor) ||
            string.IsNullOrEmpty(nomeProprietario) || string.IsNullOrEmpty(tipo))
        {
            DisplayAlert("Erro", "Todos os campos devem ser preenchidos.", "OK");
            return;
        }

        if (string.IsNullOrEmpty(sImagemSelecionada))
        {
            DisplayAlert("Erro", "Selecione uma imagem para o veículo.", "OK");
            return;
        }

        Carro carro = new Carro();
        carro.Placa = placa;    
        carro.Marca = marca;
        carro.Modelo = modelo;
        carro.Cor = cor;
        carro.NomeProprietario = nomeProprietario;
        carro.Tipo = tipo;  
        carro.DataHoraEntrada = DateTime.Now;

        carro.Imagem = ImageService.CopiarImagem(sImagemSelecionada);

        if(carroController.Insert(carro))
        {
            DisplayAlert("Sucesso", "Carro cadastrado com sucesso!", "OK");
            LimparCampos();
        }
        else
        {
            DisplayAlert("Erro", "Não foi possível cadastrar o carro.", "OK");
        }
    }

    private void LimparCampos()
    {
        txtPlaca.Text = string.Empty;
        txtMarca.Text = string.Empty;
        txtModelo.Text = string.Empty;
        txtCor.Text = string.Empty;
        txtNomeProprietario.Text = string.Empty;
        pckTipo.SelectedIndex = -1;

        LimparImagem();
    }

    private void LimparImagem()
    {
        imgSelecionada.Source = "";
        btnRemover.IsVisible = false;
    }

    private void btnRemover_Clicked(object sender, EventArgs e)
    {
        LimparImagem();

        // Volta a mostrar o botão Selecionar e esconde o Remover
        btnSelecionar.IsVisible = true;
        btnRemover.IsVisible = false;
    }
}