using System.Windows.Input;
using Microsoft.Maui.Controls.PlatformConfiguration;
using Microsoft.Maui.Controls.PlatformConfiguration.iOSSpecific;

namespace PlatformSpecifics
{
    public class iOSTranslucentNavigationBarPageCS : ContentPage
    {
        public iOSTranslucentNavigationBarPageCS(ICommand restore)
        {
            var translucentButton = new Button { Text = "Toggle Translucent Navigation Bar" };
            translucentButton.Clicked += (sender, e) => (App.Current.MainPage as Microsoft.Maui.Controls.NavigationPage).On<iOS>().SetIsNavigationBarTranslucent(!(App.Current.MainPage as Microsoft.Maui.Controls.NavigationPage).On<iOS>().IsNavigationBarTranslucent());

            var colorModeButton = new Button { Text = "Toggle Status Bar Text Color Mode" };
            colorModeButton.Clicked += (sender, e) =>
            {
                switch ((App.Current.MainPage as Microsoft.Maui.Controls.NavigationPage).On<iOS>().GetStatusBarTextColorMode())
                {
                    case StatusBarTextColorMode.MatchNavigationBarTextLuminosity:
                        (App.Current.MainPage as Microsoft.Maui.Controls.NavigationPage).On<iOS>().SetStatusBarTextColorMode(StatusBarTextColorMode.DoNotAdjust);
                        break;
                    case StatusBarTextColorMode.DoNotAdjust:
                        (App.Current.MainPage as Microsoft.Maui.Controls.NavigationPage).On<iOS>().SetStatusBarTextColorMode(StatusBarTextColorMode.MatchNavigationBarTextLuminosity);
                        break;
                }
            };

            var returnButton = new Button { Text = "Return to Platform-Specifics List" };
            returnButton.Clicked += (sender, e) => restore.Execute(null);

            Title = "Navigation Bar";
            Content = new StackLayout
            {
                Margin = new Thickness(20),
                Children = { translucentButton, colorModeButton, returnButton }
            };
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            (App.Current.MainPage as Microsoft.Maui.Controls.NavigationPage).BackgroundColor = Colors.Blue;
            (App.Current.MainPage as Microsoft.Maui.Controls.NavigationPage).BarTextColor = Colors.Black;
            (App.Current.MainPage as Microsoft.Maui.Controls.NavigationPage).On<iOS>().EnableTranslucentNavigationBar();
            (App.Current.MainPage as Microsoft.Maui.Controls.NavigationPage).On<iOS>().SetStatusBarTextColorMode(StatusBarTextColorMode.DoNotAdjust);
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();

            (App.Current.MainPage as Microsoft.Maui.Controls.NavigationPage).On<iOS>().DisableTranslucentNavigationBar();
        }
    }
}
