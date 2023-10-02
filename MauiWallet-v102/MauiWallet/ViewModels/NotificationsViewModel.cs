
namespace MauiWallet.ViewModels;
public partial class NotificationsViewModel : ObservableObject
{
    #region Properties
    [ObservableProperty]
    private bool _isBusy;

    [ObservableProperty]
    private ObservableCollection<Notification> _notifications;
    #endregion Properties

    #region Constructor
    public NotificationsViewModel()
    {
        LoadData();
    }
    #endregion

    #region Methods
    void LoadData()
    {
        IsBusy = true;
        Task.Run(async () =>
        {
            // await api call;
            await Task.Delay(1000);
            Application.Current.Dispatcher.Dispatch(() =>
            {
                Notifications = new ObservableCollection<Notification>(EwalletServices.Instance.GetNotifications);
                IsBusy = false;
            });
        });
    }
    #endregion Methods
}
