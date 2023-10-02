namespace MauiWallet.Views;
public partial class ForgotPasswordPage : ContentPage
{
	public ForgotPasswordPage()
	{
		InitializeComponent();
        BindingContext = new ForgotPasswordViewModel();
	}

    private async void GoBack_Tapped(object sender, TappedEventArgs e)
    {
        await Navigation.PopAsync();
    }

    private async void ContinueButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PasswordVerificationPage());
    }
}