namespace MauiWallet.ViewModels;
public partial class MobileTopupViewModel : ObservableObject
{
    public MobileTopupViewModel()
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
                ContactLists = new ObservableCollection<WalletContact>(EwalletServices.Instance.GetContacts);

                IsBusy = false;
            });
        });
    }

    [ObservableProperty]
    private bool _isBusy;

    [ObservableProperty]
    public ObservableCollection<WalletContact> _contactLists;
}
