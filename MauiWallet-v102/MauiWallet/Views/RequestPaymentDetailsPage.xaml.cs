namespace MauiWallet.Views;

public partial class RequestPaymentDetailsPage : ContentPage
{
	public RequestPaymentDetailsPage()
	{
		InitializeComponent();
		BindingContext = new RequestPaymentDetailsViewModel();
	}
}