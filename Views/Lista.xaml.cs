namespace BreakCar.Views;

using System.Threading.Tasks;
using BreakCar.Controllers;
using BreakCar.Models;
public partial class Lista : ContentPage
{
    private CarroController carroController;
	public Lista()
	{
        InitializeComponent();
        
        carroController = new CarroController();
        lsvLista.ItemsSource = carroController.GetAll();
    }

    private void AtualizarListView()
    {
        lsvLista.ItemsSource = carroController.GetAll();
    }

    private void btnProcurar_Clicked(object sender, EventArgs e)
    {
        string placa = txtFiltroPlaca.Text;
        DateTime? data = chkFiltroData.IsChecked ? dpFiltroData.Date : (DateTime?)null;

        string statusPagamento = pckStatusPagamento.SelectedItem?.ToString() ?? "Todos";

        var listaFiltrada = carroController.GetByFilters(placa, data, statusPagamento);
        lsvLista.ItemsSource = listaFiltrada;
    }
     

    private void chkPago_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {

    }

    private void btnAtualizar_Clicked(object sender, EventArgs e)
    {
        lsvLista.ItemsSource = carroController.GetAll();
    }

    private void tapVisualizar_Tapped(object sender, TappedEventArgs e)
    {

        TappedEventArgs tapped = (TappedEventArgs)e;
        if(tapped.Parameter is Carro registro)
        {
            var registroAtualizado = carroController.GetById(registro.Id);


            Application.Current.MainPage.Navigation.PushAsync(new Visualizador(registroAtualizado));
        }
    }

    private async void tapExcluir_Tapped(object sender, TappedEventArgs e)
    {
        TappedEventArgs tapped = (TappedEventArgs)e;
        if(tapped.Parameter is Carro registro)
        {
            bool confirmacao = await DisplayAlert("Confirmação", "Deseja Realmente Excluir Este Registro?", "Sim", "Não");

            if(confirmacao)
            {
                carroController.Delete(registro);
                AtualizarListView();
            }
        }
    }

    private void tapPagamento_Tapped(object sender, TappedEventArgs e)
    {
        TappedEventArgs tapped = (TappedEventArgs)e;
        if (tapped.Parameter is Carro carro)
        {
            if (!carro.Pago)
            {
                carro.DataHoraSaida = DateTime.Now;
                carro.Pago = true;
            }
            else
            {
                carro.DataHoraSaida = null;
                carro.Pago = false;
            }

            carroController.Update(carro);
            AtualizarListView();
        }
    }

    private void dpFiltroData_DateSelected(object sender, DateChangedEventArgs e)
    {

    }

    private void chkFiltrarPorData_Changed(object sender, CheckedChangedEventArgs e)
    {
    }

    private void chkFiltroData_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        dpFiltroData.IsVisible = e.Value; 

    }
}