using Microsoft.Maui.Controls.PlatformConfiguration;
using Microsoft.Maui.Controls.PlatformConfiguration.AndroidSpecific;

namespace PlatformSpecifics
{
    public class AndroidElevationPageCS : ContentPage
    {
        public AndroidElevationPageCS()
        {
            var outputLabel = new Label();
            var aboveButton = new Microsoft.Maui.Controls.Button { Text = "Button Above BoxView - Click Me" };
            aboveButton.Clicked += (sender, e) => outputLabel.Text = "The bottom button can receive input, while the top button cannot.";
            aboveButton.On<Microsoft.Maui.Controls.PlatformConfiguration.Android>().SetElevation(10);
            
            Title = "Elevation";
            Content = new StackLayout
            {
                Margin = new Thickness(20),
                Children = {
                    new Grid
                    {
                        Children = {
                            new Microsoft.Maui.Controls.Button { Text = "Button Beneath BoxView" },
                            new BoxView { Color = Colors.Red, Opacity = 0.2, HeightRequest = 50 }
                        }
                    },
                    new Grid
                    {
                        Margin = new Thickness(0,20,0,0),
                        Children = {
                            aboveButton,
                            new BoxView { Color = Colors.Red, Opacity = 0.2, HeightRequest = 50 }
                        }
                    },
                    outputLabel
                }
            };
        }
    }
}
