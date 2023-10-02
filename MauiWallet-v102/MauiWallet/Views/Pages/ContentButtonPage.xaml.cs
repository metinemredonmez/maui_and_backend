namespace MauiWallet.Views.Pages
{
    public partial class ContentButtonPage : ContentPage
    {
        public ContentButtonPage()
        {
            InitializeComponent();
        }

        private void StarButtonClicked(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync(nameof(ImagePage));
        }
    }
}
