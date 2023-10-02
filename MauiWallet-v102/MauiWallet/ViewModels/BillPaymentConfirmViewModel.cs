namespace MauiWallet.ViewModels;

public partial class BillPaymentConfirmViewModel : ObservableObject
{
    public BillPaymentConfirmViewModel()
    {

    }

    [RelayCommand]
    private async void PaymentConfirm()
    {
        await PopupAction.DisplayPopup(new BillPaySuccessPopup());
    }
}
