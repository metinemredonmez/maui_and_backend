
namespace MauiWallet.Views.Onboardings;

public partial class WalkthroughIllustrationPage : ContentPage
{
	public WalkthroughIllustrationPage()
	{
		InitializeComponent();
		BindingContext = new WalkthroughIllustrationViewModel(Navigation, this);

    }
}