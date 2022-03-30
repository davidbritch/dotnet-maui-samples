using Microsoft.Maui.Controls.PlatformConfiguration;
using Microsoft.Maui.Controls.PlatformConfiguration.iOSSpecific;

namespace PlatformSpecifics
{
    public class iOSFirstResponderPageCS : ContentPage
    {
        public iOSFirstResponderPageCS()
        {
            Microsoft.Maui.Controls.Entry firstEntry = new Microsoft.Maui.Controls.Entry { Placeholder = "First Entry" };
            Button firstButton = new Button { Text = "OK" };

            Microsoft.Maui.Controls.Entry secondEntry = new Microsoft.Maui.Controls.Entry { Placeholder = "Second Entry" };
            Button secondButton = new Button { Text = "OK" };
            secondButton.On<iOS>().SetCanBecomeFirstResponder(true);

            Title = "VisualElement first responder";
            Content = new StackLayout
            {
                Margin = new Thickness(10),
                Children =
                {
                    new Label { Text = "Click in the first Entry to make the keyboard appear. Then click OK and the keyboard should disappear." },
                    firstEntry,
                    firstButton,
                    new Label { Text = "Click in the second Entry to make the keyboard appear. Then click OK and the keyboard shouldn't disappear." },
                    secondEntry,
                    secondButton
                }
            };
        }
    }
}
