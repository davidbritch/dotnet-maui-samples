using System.Windows.Input;
using Microsoft.Maui.Controls.PlatformConfiguration;
using Microsoft.Maui.Controls.PlatformConfiguration.iOSSpecific;

namespace PlatformSpecifics
{
    public class iOSScrollViewPageCS : Microsoft.Maui.Controls.FlyoutPage
    {
        public iOSScrollViewPageCS(ICommand restore)
        {
            var scrollView = new Microsoft.Maui.Controls.ScrollView();
            var button = new Button { Text = "Toggle ScrollView DelayContentTouches" };
            button.Clicked += (sender, e) => scrollView.On<iOS>().SetShouldDelayContentTouches(!scrollView.On<iOS>().ShouldDelayContentTouches());

            var returnButton = new Button { Text = "Return to Platform-Specifics List" };
            returnButton.Clicked += (sender, e) => restore.Execute(null);

            scrollView.Content = new StackLayout
            {
                Margin = new Thickness(0, 20),
                Children = { new Microsoft.Maui.Controls.Slider(), button, returnButton }
            };
            scrollView.On<iOS>().SetShouldDelayContentTouches(false);

            Flyout = new ContentPage { Title = "Menu", BackgroundColor = Colors.Blue };
            Detail = new ContentPage { Content = scrollView };
        }
    }
}
