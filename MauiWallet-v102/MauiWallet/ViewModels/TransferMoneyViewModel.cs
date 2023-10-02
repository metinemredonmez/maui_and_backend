namespace MauiWallet.ViewModels;
public partial class TransferMoneyViewModel : ObservableObject
{
    public TransferMoneyViewModel()
    {

    }

    [RelayCommand]
    private async void GotoPaymentConfirm()
    {
        await Shell.Current.GoToAsync(nameof(PaymentConfirmPage));
    }
}
