namespace MauiAppHotelDupim.Views;

public partial class SobrePage : ContentPage
{
	public SobrePage()
	{
		InitializeComponent();
	}

    private async void OnSobreButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ContratacaoHospedagem());
    }
}