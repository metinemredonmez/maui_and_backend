namespace MauiWallet;
public partial class NormalAppShell : Shell
{
    public NormalAppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute(nameof(DemoStartPage), typeof(DemoStartPage));
        Routing.RegisterRoute(nameof(DemoWalkthroughPage), typeof(DemoWalkthroughPage));
        Routing.RegisterRoute(nameof(ImagePage), typeof(ImagePage));
        Routing.RegisterRoute(nameof(MobileTopupPage), typeof(MobileTopupPage));
        Routing.RegisterRoute(nameof(BillPaymentConfirmPage), typeof(BillPaymentConfirmPage));
        Routing.RegisterRoute(nameof(AllServicePage), typeof(AllServicePage));
        Routing.RegisterRoute(nameof(TransferMoneyPage), typeof(TransferMoneyPage));
        Routing.RegisterRoute(nameof(RequestPaymentPage), typeof(RequestPaymentPage));
        Routing.RegisterRoute(nameof(RequestPaymentDetailsPage), typeof(RequestPaymentDetailsPage));
        Routing.RegisterRoute(nameof(PaymentConfirmPage), typeof(PaymentConfirmPage));
        Routing.RegisterRoute(nameof(EReceiptPage), typeof(EReceiptPage));
        Routing.RegisterRoute(nameof(ScanQrPayPage), typeof(ScanQrPayPage));
        Routing.RegisterRoute(nameof(NotificationsPage), typeof(NotificationsPage));
        Routing.RegisterRoute(nameof(PrivacyPolicyPage), typeof(PrivacyPolicyPage));

        Routing.RegisterRoute(nameof(FirstYellowDetailPage), typeof(FirstYellowDetailPage));
        Routing.RegisterRoute(nameof(SecondYellowDetailPage), typeof(SecondYellowDetailPage));
        Routing.RegisterRoute(nameof(ThirdYellowDetailPage), typeof(ThirdYellowDetailPage));
        Routing.RegisterRoute(nameof(FirstGreenDetailPage), typeof(FirstGreenDetailPage));
    }
}
