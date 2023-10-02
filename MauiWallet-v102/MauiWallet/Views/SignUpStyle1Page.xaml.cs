namespace MauiWallet.Views;
public partial class SignUpStyle1Page : ContentPage
{
	public SignUpStyle1Page()
	{
		InitializeComponent();
	}

    private async void GoBack_Tapped(object sender, TappedEventArgs e)
    {
        await Navigation.PopAsync();
    }

    private async void Signin_Tapped(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new LoginStyle1Page());
    }
}