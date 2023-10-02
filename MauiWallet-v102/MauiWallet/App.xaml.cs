namespace MauiWallet;
internal enum AppShellType
{
    Normal, Sample, Main
}

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        #region Handlers

        //Borderless entry
        Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping(nameof(BorderlessEntry), (handler, view) =>
        {
            if (view is BorderlessEntry)
            {
#if __ANDROID__
            handler.PlatformView.SetBackgroundColor(Android.Graphics.Color.Transparent);
#elif __IOS__
                handler.PlatformView.BorderStyle = UIKit.UITextBorderStyle.None;
#elif __WINDOWS__
            handler.PlatformView.TextBox.BorderThickness = new Thickness(0);
#endif
            }
        });

        //Borderless editor
        Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping(nameof(BorderlessEditor), (handler, view) =>
        {
            if (view is BorderlessEditor)
            {
#if __ANDROID__
            handler.PlatformView.SetBackgroundColor(Android.Graphics.Color.Transparent);
#elif __IOS__
                handler.PlatformView.BorderStyle = UIKit.UITextBorderStyle.None;
#elif __WINDOWS__
            handler.PlatformView.BorderThickness = new Thickness(0);
#endif
            }
        });

        #endregion

        if (AppSettings.AppSettings.IsFirstLaunching)
        {
            AppSettings.AppSettings.IsFirstLaunching = true; //set to False in production
            MainPage = new NavigationPage(new DemoStartPage());
        }
        else
            MainPage = MauiProgram.UsedAppShell switch
            {
                AppShellType.Normal => new NormalAppShell(),
                AppShellType.Sample => new SampleAppShell(),
                _ => new MainAppShell()
            };

        //MainPage = MauiProgram.UsedAppShell switch
        //{
        //    AppShellType.Normal => new NormalAppShell(),
        //    AppShellType.Sample => new SampleAppShell(),
        //    _ => new MainAppShell()
        //};
    }
}