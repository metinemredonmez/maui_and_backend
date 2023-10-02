
using System.Collections.ObjectModel;

namespace MauiWallet.Views
{
    public partial class ThemeSettingsPopupPage : BasePopupPage
    {
        public ThemePalette SelectedPrimaryColorItem { get; set; }
        public ThemeSettingsPopupPage()
        {
            InitializeComponent();

            this.MainContent.FadeTo(1, 100, Easing.BounceIn);
            this.MainContent.TranslateTo(this.MainContent.TranslationX, 0);

            this.BindingContext = AppSettings.AppSettings.Instance;

            Application.Current.Resources.TryGetValue("ThemePrimaryColorOption1", out var primaryColorOption1);
            Application.Current.Resources.TryGetValue("ThemePrimaryColorOption2", out var primaryColorOption2);
            Application.Current.Resources.TryGetValue("ThemePrimaryColorOption3", out var primaryColorOption3);
            Application.Current.Resources.TryGetValue("ThemePrimaryColorOption4", out var primaryColorOption4);
            Application.Current.Resources.TryGetValue("ThemePrimaryColorOption5", out var primaryColorOption5);

            var colorItems = new List<ThemePalette>
            {
                new ThemePalette()
                {
                    Index = 0,
                    Color = (Color)primaryColorOption1
                },
                new ThemePalette()
                {
                    Index = 1,
                    Color = (Color)primaryColorOption2
                },
                new ThemePalette()
                {
                    Index = 2,
                    Color = (Color)primaryColorOption3
                },
                new ThemePalette()
                {
                    Index = 3,
                    Color = (Color)primaryColorOption4
                },
                new ThemePalette()
                {
                    Index = 4,
                    Color = (Color)primaryColorOption5
                }
            };

            var viewCollection = new ObservableCollection<ThemePalette>();

            foreach (var colorItem in colorItems)
            {
                viewCollection.Add(colorItem);
            }

            this.colorPaletteCollectionView.ItemsSource = viewCollection;

            this.UpdatePrimaryColor();
            this.colorPaletteCollectionView.SelectionChanged += (sender, e) =>
            {
                var selectedItem = e.CurrentSelection.FirstOrDefault() as ThemePalette;
                AppSettings.AppSettings.Instance.SelectedPrimaryColor = selectedItem.Index;
            };
        }

        async void OnCloseSetting_Tapped(object sender, TappedEventArgs e)
        {
            await PopupAction.ClosePopup();
        }

        private void OnRTL_Toggled(object sender, ToggledEventArgs e)
        {
            AppSettings.AppSettings.Instance.EnableRTL = e.Value;
        }

        private void OnSettingLightTheme_Clicked(object sender, EventArgs e)
        {
            Application.Current.Resources.ApplyLightTheme();
            AppSettings.AppSettings.Instance.SelectedPrimaryColor = 0;
            this.UpdatePrimaryColor();
        }

        private void OnSettingDarkTheme_Clicked(object sender, EventArgs e)
        {
            Application.Current.Resources.ApplyDarkTheme();
            AppSettings.AppSettings.Instance.SelectedPrimaryColor = 1;
            this.UpdatePrimaryColor();
        }

        private void colorPaletteCollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedItem = e.CurrentSelection.FirstOrDefault() as ThemePalette;
            SelectedPrimaryColorItem = selectedItem;
            AppSettings.AppSettings.Instance.SelectedPrimaryColor = selectedItem.Index;
            this.UpdatePrimaryColor();
        }
        private void UpdatePrimaryColor()
        {
            Application.Current.Resources.TryGetValue("PrimaryColor", out var primaryColor);
            Application.Current.Resources.TryGetValue("White", out var white);
            Application.Current.Resources.TryGetValue("Gray600", out var gray600);
            Application.Current.Resources.TryGetValue("Black", out var black);

            if (AppSettings.AppSettings.Instance.IsDarkTheme == false)
            {
                this.lightThemeButton.BackgroundColor = (Color)primaryColor;
                this.lightThemeButton.TextColor = (Color)white;
                this.darkThemeButton.BackgroundColor = (Color)gray600;
                this.darkThemeButton.TextColor = (Color)white;
            }
            else
            {
                this.lightThemeButton.BackgroundColor = (Color)gray600;
                this.lightThemeButton.TextColor = (Color)black;
                this.darkThemeButton.BackgroundColor = (Color)primaryColor;
                this.darkThemeButton.TextColor = (Color)white;
            }
        }

    }
}
