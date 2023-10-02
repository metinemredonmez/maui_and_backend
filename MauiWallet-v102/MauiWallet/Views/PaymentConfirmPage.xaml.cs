namespace MauiWallet.Views;

public partial class PaymentConfirmPage : ContentPage
{
	public PaymentConfirmPage()
	{
		InitializeComponent();
		BindingContext = new PaymentConfirmViewModel();
	}
}