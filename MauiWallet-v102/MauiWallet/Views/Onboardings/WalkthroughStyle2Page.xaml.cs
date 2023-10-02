using MauiWallet.ViewModels.Onboardings;

namespace MauiWallet.Views.Onboardings;

public partial class WalkthroughStyle2Page : ContentPage
{
	public WalkthroughStyle2Page()
	{
		InitializeComponent();
		BindingContext = new WalkthroughStyle2ViewModel(Navigation, this);

    }
}