namespace MauiWallet.Views;
public partial class AccountUpdatePage : BasePopupPage
{
    public AccountUpdatePage()
    {
        InitializeComponent();
    }

    private async void SubmitButton_Clicked(object sender, EventArgs e)
    {
        await PopupAction.ClosePopup();
    }
}
