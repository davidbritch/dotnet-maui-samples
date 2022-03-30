using Microsoft.Maui.Controls.PlatformConfiguration;
using Microsoft.Maui.Controls.PlatformConfiguration.iOSSpecific;

namespace PlatformSpecifics
{
    public class iOSShadowEffectPageCS : ContentPage
    {
        public iOSShadowEffectPageCS()
        {
            var boxView = new BoxView { Color = Colors.Aqua, WidthRequest = 100, HeightRequest = 100 };
            boxView.On<iOS>()
                   .SetIsShadowEnabled(true)
                   .SetShadowColor(Colors.Purple)
                   .SetShadowOffset(new Size(10,10))
                   .SetShadowOpacity(0.7)
                   .SetShadowRadius(12);

            var toggleButton = new Button { Text = "Toggle Shadow Effect" };
            toggleButton.Clicked += (sender, e) => boxView.On<iOS>().SetIsShadowEnabled(!boxView.On<iOS>().GetIsShadowEnabled());

            Title = "Shadow Effect";
            Content = new StackLayout
            {
                Margin = new Thickness(20),
                Children = { boxView, toggleButton }
            };
        }
    }
}
