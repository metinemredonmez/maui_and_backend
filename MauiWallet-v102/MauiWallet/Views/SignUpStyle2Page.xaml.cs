namespace MauiWallet.Views;

public partial class SignUpStyle2Page : ContentPage
{
	public SignUpStyle2Page()
	{
		InitializeComponent();
	}

    private async void GoBack_Tapped(object sender, TappedEventArgs e)
    {
        await Navigation.PopAsync();
    }

    private async void SignInButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new LoginStyle2Page());
    }
}