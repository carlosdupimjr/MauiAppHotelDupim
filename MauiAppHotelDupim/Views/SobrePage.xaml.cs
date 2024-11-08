namespace MauiAppHotelDupim.Views;

public partial class SobrePage : ContentPage
{
	public SobrePage()
	{
		InitializeComponent();
	}

    private async void OnBackButtonClicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}