namespace BreakCar.Views;
using BreakCar.Models;

public partial class Visualizador : ContentPage
{
	public Visualizador(Carro carro)
	{
		InitializeComponent();
        ExibirDados(carro);

    }

    private void ExibirDados(Carro carro)
    {
        lblVisId.Text = carro.Id.ToString();
        lblVisPlaca.Text = carro.Placa;
        lblVisMarca.Text = carro.Marca;
        lblVisModelo.Text = carro.Modelo;
        lblVisCor.Text = carro.Cor;
        lblVisNomeProprietario.Text = carro.NomeProprietario;
        lblVisTipo.Text = carro.Tipo;
        lblDataHoraEntrada.Text = carro.DataHoraEntrada.ToString("dd/MM/yyyy HH:mm:ss");

        lblDataHoraSaida.Text = carro.DataHoraSaida?.ToString("dd/MM/yyyy HH:mm:ss") ?? "Carro Ainda Estacionado";
        lblStatusPagamento.Text = carro.Pago ? "Pago" : "Não Pago";
    }
}
