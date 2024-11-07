using System.Linq.Expressions;

namespace MauiAppHotelDupim.Views;

public partial class ContratacaoHospedagem : ContentPage
{
	public ContratacaoHospedagem()
	{
		InitializeComponent();
	}

    private async void OnAvancarButtonClicked(object sender, EventArgs e)
    {
        try
        {
            await Navigation.PushAsync(new HospedagemContratada());
        }   catch (Exception ex)
                {
            DisplayAlert("Ops", ex.Message, "OK");
                }

        
    }
    private async void OnSobreButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new SobrePage());
    }
}
