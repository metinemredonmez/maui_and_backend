namespace MauiWallet.Views.Forms;

public partial class SimpleSignUpPage : ContentPage
{
	public SimpleSignUpPage()
	{
		InitializeComponent();
	}

    private async void GoBack_Tapped(object sender, EventArgs e)
    {
        await Navigation.PopModalAsync();
    }
}