using MauiWallet.ViewModels.Onboardings;

namespace MauiWallet.Views.Onboardings;

public partial class WalkthroughStyle1Page : ContentPage
{
    const uint DURATION_NAME = 550;
    const uint DURATION_IMG = 300;
    public WalkthroughStyle1Page()
	{
		InitializeComponent();
		BindingContext = new WalkthroughStyle1ViewModel(Navigation, this);

        //headerLabel.TranslationX = -150;
        //descriptionLabel.TranslationX = -300;
        //image.TranslationX = 350;
    }

    protected override async void OnAppearing()
    {
        //await Task.WhenAll(
        //    headerLabel.TranslateTo(-150, 0, DURATION_NAME, Easing.Linear),
        //    headerLabel.TranslateTo(-75, 0, DURATION_NAME, Easing.Linear),
        //    headerLabel.TranslateTo(0, 0, DURATION_NAME, Easing.Linear),
        //    descriptionLabel.TranslateTo(-300, 0, DURATION_NAME, Easing.Linear),
        //    descriptionLabel.TranslateTo(-150, 0, DURATION_NAME, Easing.Linear),
        //    descriptionLabel.TranslateTo(0, 0, DURATION_NAME, Easing.Linear)
        //);

        //await image.TranslateTo(350, 0, DURATION_IMG, Easing.Linear);
        //await image.FadeTo(0.5, DURATION_IMG, Easing.Linear);
        //await image.TranslateTo(175, 0, DURATION_IMG, Easing.Linear);
        //await image.TranslateTo(0, 0, DURATION_IMG, Easing.Linear);
        //await image.FadeTo(1, DURATION_IMG, Easing.Linear);
    }
}