using MauiWallet.ViewModels.Onboardings;

namespace MauiWallet.Views.Onboardings;

public partial class WalkthroughAnimationPage : ContentPage
{
	public WalkthroughAnimationPage()
	{
		InitializeComponent();
		BindingContext = new WalkthroughAnimationViewModel(Navigation, this);
		
    }
}