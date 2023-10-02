namespace MauiWallet.Views;

public partial class BillPaymentPage : ContentPage
{
	public BillPaymentPage()
	{
		InitializeComponent();
		BindingContext = new BillPaymentViewModel();
	}
}