namespace MauiWallet.Views;

public partial class TransferMoneyPage : ContentPage
{
	public TransferMoneyPage()
	{
		InitializeComponent();
		BindingContext = new TransferMoneyViewModel();
	}
}