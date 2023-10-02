namespace MauiWallet.Views;
public partial class TransferSuccessPopup : BasePopupPage
{
	public TransferSuccessPopup()
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