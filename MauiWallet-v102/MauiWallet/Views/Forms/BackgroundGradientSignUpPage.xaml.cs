namespace MauiWallet.Views.Forms;

public partial class BackgroundGradientSignUpPage : ContentPage
{
	public BackgroundGradientSignUpPage()
	{
		InitializeComponent();
	}

    private async void GoBack_Tapped(object sender, EventArgs e)
    {
        await Navigation.PopModalAsync();
    }
}