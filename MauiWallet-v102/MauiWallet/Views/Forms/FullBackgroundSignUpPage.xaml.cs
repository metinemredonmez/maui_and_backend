namespace MauiWallet.Views.Forms;

public partial class FullBackgroundSignUpPage : ContentPage
{
	public FullBackgroundSignUpPage()
	{
		InitializeComponent();
	}

    private async void GoBack_Tapped(object sender, EventArgs e)
    {
        await Navigation.PopModalAsync();
    }
}