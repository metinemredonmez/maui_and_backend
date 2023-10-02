
namespace MauiWallet.ViewModels;
public partial class MyCardsViewModel : ObservableObject
{
    public MyCardsViewModel()
    {
        LoadData();
    }

    void LoadData()
    {
        Task.Run(async () =>
        {
            IsBusy = true;
            // await api call;
            await Task.Delay(1000);
            Application.Current.Dispatcher.Dispatch(() =>
            {
                MyCardLists = new ObservableCollection<CardData>(EwalletServices.Instance.GetMyCards);

                IsBusy = false;
            });
        });
    }

    [ObservableProperty]
    private bool _isBusy;

    [ObservableProperty]
    public ObservableCollection<CardData> _myCardLists;

    [RelayCommand]
    private async void CardOptions()
    {
        await PopupAction.DisplayPopup(new CardOptionsPopup());
    }
}
