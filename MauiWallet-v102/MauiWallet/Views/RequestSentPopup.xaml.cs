namespace MauiWallet.Views;
public partial class RequestSentPopup : BasePopupPage
{
	public RequestSentPopup()
	{
		InitializeComponent();
	}

    private async void ViewReceiptButton_Clicked(object sender, EventArgs e)
    {
        await PopupAction.ClosePopup();
    }
    private async void CloseButton_Clicked(object sender, EventArgs e)
    {
        await PopupAction.ClosePopup();
    }
}