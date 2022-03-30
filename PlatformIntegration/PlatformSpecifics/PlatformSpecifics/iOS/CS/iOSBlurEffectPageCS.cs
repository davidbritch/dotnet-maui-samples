using Microsoft.Maui.Controls.PlatformConfiguration;
using Microsoft.Maui.Controls.PlatformConfiguration.iOSSpecific;

namespace PlatformSpecifics
{
    public class iOSBlurEffectPageCS : ContentPage
    {
        public iOSBlurEffectPageCS()
        {
            Image image = new Image { Source = "monkeyface.png" };
            image.On<iOS>().UseBlurEffect(BlurEffectStyle.ExtraLight);

            var noBlurButton = new Button { Text = "No Blur" };
            noBlurButton.Clicked += (sender, e) => image.On<iOS>().UseBlurEffect(BlurEffectStyle.None);
            var extraLightBlurButton = new Button { Text = "Extra Light Blur" };
            extraLightBlurButton.Clicked += (sender, e) => image.On<iOS>().UseBlurEffect(BlurEffectStyle.ExtraLight);
            var lightBlurButton = new Button { Text = "Light Blur" };
            lightBlurButton.Clicked += (sender, e) => image.On<iOS>().UseBlurEffect(BlurEffectStyle.Light);
            var darkBlurButton = new Button { Text = "Dark Blur" };
            darkBlurButton.Clicked += (sender, e) => image.On<iOS>().UseBlurEffect(BlurEffectStyle.Dark);

            Title = "Blur Effect";
            Content = new StackLayout
            {
                Margin = new Thickness(20),
                Children =
                {
                    image,
                    noBlurButton, extraLightBlurButton, lightBlurButton, darkBlurButton
                }
            };
        }
    }
}
