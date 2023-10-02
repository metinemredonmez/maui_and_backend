namespace MauiWallet.Views.Forms;

public partial class SimpleLoginPage : ContentPage
{
	public SimpleLoginPage()
	{
		InitializeComponent();
	}

    private async void GoBack_Tapped(object sender, EventArgs e)
    {
        await Navigation.PopModalAsync();
    }
}