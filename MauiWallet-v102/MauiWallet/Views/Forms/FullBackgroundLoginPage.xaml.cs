namespace MauiWallet.Views.Forms;

public partial class FullBackgroundLoginPage : ContentPage
{
	public FullBackgroundLoginPage()
	{
		try
        {
            InitializeComponent();
        }
        catch(Exception e)
        {

        }
	}

    private async void ForgotPassword_Tapped(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ForgotPasswordPage());
        //await Shell.Current.GoToAsync(nameof(ForgotPasswordPage), true);
    }

    private async void GoBack_Tapped(object sender, EventArgs e)
    {
        await Navigation.PopModalAsync();
    }
}