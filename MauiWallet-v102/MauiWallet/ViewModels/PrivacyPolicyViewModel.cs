
namespace MauiWallet.ViewModels;
public partial class PrivacyPolicyViewModel : ObservableObject
{
    [ObservableProperty]
    string _url;
    public PrivacyPolicyViewModel()
    {
        Url = "http://tlssoftwarevn.com/m-wallet-privacy.html";
    }
}
