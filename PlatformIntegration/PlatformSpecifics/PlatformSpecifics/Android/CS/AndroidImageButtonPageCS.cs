using Microsoft.Maui.Controls.PlatformConfiguration;
using Microsoft.Maui.Controls.PlatformConfiguration.AndroidSpecific;

namespace PlatformSpecifics
{
    public class AndroidImageButtonPageCS : ContentPage
    {
        public AndroidImageButtonPageCS()
        {
            var imageButton = new Microsoft.Maui.Controls.ImageButton { Source = "XamarinLogo.png", BackgroundColor = Colors.GhostWhite, HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center };
            imageButton.Clicked += (sender, e) => imageButton.On<Microsoft.Maui.Controls.PlatformConfiguration.Android>().SetIsShadowEnabled(!imageButton.On<Microsoft.Maui.Controls.PlatformConfiguration.Android>().GetIsShadowEnabled());

            imageButton.On<Microsoft.Maui.Controls.PlatformConfiguration.Android>()
                       .SetIsShadowEnabled(true)
                       .SetShadowColor(Colors.Gray)
                       .SetShadowOffset(new Size(10, 10))
                       .SetShadowRadius(12);

            Title = "Android ImageButton";
            Content = new StackLayout
            {
                Margin = new Thickness(20),
                Children = {
                    imageButton,
                    new Label { Text = "Tap the ImageButton to toggle the shadow effect.", FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)), HorizontalOptions = LayoutOptions.Center }
                }
            };
        }
    }
}
