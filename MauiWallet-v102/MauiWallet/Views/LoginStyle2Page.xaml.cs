namespace MauiWallet.Views;
public partial class LoginStyle2Page : ContentPage
{
	public LoginStyle2Page()
	{
		InitializeComponent();
        BindingContext = new LoginViewModel();
	}

    private async void GoBack_Tapped(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new DemoStartPage());
    }

    private async void SigninButton_Clicked(object sender, EventArgs e)
    {
        Application.Current.MainPage = MauiProgram.UsedAppShell switch
        {
            AppShellType.Normal => new NormalAppShell(),
            AppShellType.Sample => new SampleAppShell(),
            _ => new MainAppShell()
        };
    }

    private async void ForgotPasswordButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ForgotPasswordPage());
    }

    private async void Signup_Tapped(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new SignUpStyle2Page());
    }
}