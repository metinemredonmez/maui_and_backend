namespace MauiWallet.Views;
public partial class NotificationsPage : ContentPage
{
    public NotificationsPage()
    {
        InitializeComponent();
        BindingContext = new NotificationsViewModel();
    }

    private async void GoBack_Tapped(object sender, TappedEventArgs e)
    {
        await Navigation.PopModalAsync();
    }
}
