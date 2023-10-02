
namespace MauiWallet.ViewModels.Onboardings;
public partial class WalkthroughStyle2ViewModel : ObservableObject
{
    private INavigation _navigationService;
    private Page _pageService;
    public WalkthroughStyle2ViewModel(INavigation navigationService, Page pageService)
    {
        _navigationService = navigationService;
        _pageService = pageService;

        Boardings = new ObservableCollection<Boarding>();
        CreateBoardingCollection();
    }

    void CreateBoardingCollection()
    {
        Boardings = new ObservableCollection<Boarding>()
        {
            new Boarding
            {
                ImagePath = "walkthrough_01_image.jpg",
                Title = AppTranslations.StringWalkthroughTitleStep1,
                Subtitle = AppTranslations.StringWalkthroughSubtitleStep1
            },
            new Boarding
            {
                ImagePath = "walkthrough_02_image.jpg",
                Title = AppTranslations.StringWalkthroughTitleStep2,
                Subtitle = AppTranslations.StringWalkthroughSubtitleStep2
            },
            new Boarding
            {
                ImagePath = "walkthrough_03_image.jpg",
                Title = AppTranslations.StringWalkthroughTitleStep3,
                Subtitle = AppTranslations.StringWalkthroughSubtitleStep3
            }
        };
    }

    #region Commands

    [RelayCommand]
    private async void Skip(object obj)
    {
        await CloseWalkThroughPage();
    }

    [RelayCommand]
    private async void Next(object obj)
    {
        if (ValidateAndUpdatePosition())
        {
            await CloseWalkThroughPage();
        }

    }
    #endregion

    #region Methods
    private bool ValidateAndUpdatePosition()
    {
        ValidateSelection(Position + 1);
        if (Position >= Boardings.Count - 1)
            return true;
        Position = Position + 1;
        return false;
    }

    private void ValidateSelection(int index)
    {
        if (index <= Boardings.Count - 2)
        {
            IsSkipButtonVisible = true;
            NextButtonText = "NEXT";
        }
        else
        {
            NextButtonText = "FINISH";
            IsSkipButtonVisible = false;
        }
    }

    private async Task CloseWalkThroughPage()
    {
        await _navigationService.PopAsync();
    }

    #endregion

    #region Properties

    [ObservableProperty]
    public ObservableCollection<Boarding> _boardings;

    [ObservableProperty]
    private bool _isSkipButtonVisible = true;

    [ObservableProperty]
    private int _position = 0;

    [ObservableProperty]
    private string _nextButtonText = "NEXT";

    #endregion
}
