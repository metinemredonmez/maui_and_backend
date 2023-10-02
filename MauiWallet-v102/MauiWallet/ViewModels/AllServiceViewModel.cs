namespace MauiWallet.ViewModels;
public partial class AllServiceViewModel : ObservableObject
{
    public AllServiceViewModel()
    {
        LoadData();
    }

    void LoadData()
    {
        Task.Run(async () =>
        {
            IsBusy = true;
            // await api call;
            await Task.Delay(500);
            Application.Current.Dispatcher.Dispatch(() =>
            {
                AllServices = new ObservableCollection<ServiceCategoryGroup>(EwalletServices.Instance.GetAllServices);

                IsBusy = false;
            });
        });
    }

    [ObservableProperty]
    private bool _isBusy;

    [ObservableProperty]
    public ObservableCollection<ServiceCategoryGroup> _allServices;
}
