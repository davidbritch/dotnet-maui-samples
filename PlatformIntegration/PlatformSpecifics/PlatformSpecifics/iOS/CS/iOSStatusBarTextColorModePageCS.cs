using System.Windows.Input;
using Microsoft.Maui.Controls.PlatformConfiguration;
using Microsoft.Maui.Controls.PlatformConfiguration.iOSSpecific;

namespace PlatformSpecifics
{
    public class iOSStatusBarTextColorModePageCS : Microsoft.Maui.Controls.FlyoutPage
    {
        public iOSStatusBarTextColorModePageCS(ICommand restore)
        {
            var returnButton = new Button { Text = "Return to Platform-Specifics List" };
            returnButton.Clicked += (sender, e) => restore.Execute(null);

            Flyout = new ContentPage { Title = "FlyoutPage Title" };
            Detail = new Microsoft.Maui.Controls.NavigationPage(new ContentPage
            {
                Content = new StackLayout
                {
                    Margin = new Thickness(20),
                    Children = {
                        new Label { Text = "Slide the flyout page to see the status bar text color mode change." },
                        returnButton
                    }
                }
            });

            ((Microsoft.Maui.Controls.NavigationPage)Detail).BarBackgroundColor = Colors.Blue;
            ((Microsoft.Maui.Controls.NavigationPage)Detail).BarTextColor = Colors.White;

            IsPresentedChanged += (sender, e) =>
            {
                var mdp = sender as Microsoft.Maui.Controls.FlyoutPage;
                if (mdp.IsPresented)
                    ((Microsoft.Maui.Controls.NavigationPage)mdp.Detail).On<iOS>().SetStatusBarTextColorMode(StatusBarTextColorMode.DoNotAdjust);
                else
                    ((Microsoft.Maui.Controls.NavigationPage)mdp.Detail).On<iOS>().SetStatusBarTextColorMode(StatusBarTextColorMode.MatchNavigationBarTextLuminosity);
            };
        }
    }
}
