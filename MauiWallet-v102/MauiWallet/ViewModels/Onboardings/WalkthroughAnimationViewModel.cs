
namespace MauiWallet.ViewModels.Onboardings;
public partial class WalkthroughAnimationViewModel : ObservableObject
{
    private INavigation _navigationService;
    private Page _pageService;
    public WalkthroughAnimationViewModel(INavigation navigationService, Page pageService)
    {
        _navigationService = navigationService;
        _pageService = pageService;

        Boardings = new ObservableCollection<Boarding>();
        CreateBoardingCollection();
    }

    void CreateBoardingCollection()
    {
        _boardings.Add(new Boarding
        {
            ImagePath = "initialanimation.json",
            Title = AppTranslations.StringWalkthroughTitleStep1,
            Subtitle = AppTranslations.StringWalkthroughSubtitleStep1
        });

        _boardings.Add(new Boarding
        {
            ImagePath = "payment.json",
            Title = AppTranslations.StringWalkthroughTitleStep2,
            Subtitle = AppTranslations.StringWalkthroughSubtitleStep2
        });

        _boardings.Add(new Boarding
        {
            ImagePath = "todo.json",
            Title = AppTranslations.StringWalkthroughTitleStep3,
            Subtitle = AppTranslations.StringWalkthroughSubtitleStep3
        });

        Boardings = new ObservableCollection<Boarding>(_boardings);
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
