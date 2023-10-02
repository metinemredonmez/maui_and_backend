namespace MauiWallet.Views;
public partial class CardOptionsPopup : BasePopupPage
{
	public CardOptionsPopup()
	{
		InitializeComponent();
	}

    private async void OnChangeLimit_Tapped(object sender, TappedEventArgs e)
    {
        await PopupAction.ClosePopup();
    }
    private async void OnTopup_Tapped(object sender, TappedEventArgs e)
    {
        await PopupAction.ClosePopup();
    }
    private async void OnRefund_Tapped(object sender, TappedEventArgs e)
    {
        await PopupAction.ClosePopup();
    }
    private async void OnTemporaryBlock_Tapped(object sender, TappedEventArgs e)
    {
        await PopupAction.ClosePopup();
    }
    private async void OnPermanentBlock_Tapped(object sender, TappedEventArgs e)
    {
        await PopupAction.ClosePopup();
    }
}