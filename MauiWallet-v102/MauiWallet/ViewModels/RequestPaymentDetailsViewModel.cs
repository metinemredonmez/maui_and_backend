namespace MauiWallet.ViewModels;
public partial class RequestPaymentDetailsViewModel : ObservableObject
{
    public RequestPaymentDetailsViewModel()
    {

    }

    [RelayCommand]
    private async void SendRequest()
    {
        await PopupAction.DisplayPopup(new RequestSentPopup());
    }
}
