using Microsoft.Maui.Controls.PlatformConfiguration;
using Microsoft.Maui.Controls.PlatformConfiguration.iOSSpecific;

namespace PlatformSpecifics
{
    public class iOSTimePickerPageCS : ContentPage
    {
        public iOSTimePickerPageCS()
        {
            Microsoft.Maui.Controls.TimePicker timePicker = new Microsoft.Maui.Controls.TimePicker
            {
                Time = new TimeSpan(14,00,00)
            };

            Button button = new Button
            {
                Text = "Toggle TimePicker UpdateMode"
            };
            button.Clicked += (sender, e) =>
            {
                switch (timePicker.On<iOS>().UpdateMode())
                {
                    case UpdateMode.Immediately:
                        timePicker.On<iOS>().SetUpdateMode(UpdateMode.WhenFinished);
                        break;
                    case UpdateMode.WhenFinished:
                        timePicker.On<iOS>().SetUpdateMode(UpdateMode.Immediately);
                        break;
                }
            };
            timePicker.On<iOS>().SetUpdateMode(UpdateMode.WhenFinished);

            Title = "TimePicker UpdateMode";
            Content = new StackLayout
            {
                Margin = new Thickness(10),
                Children =
                {
                    timePicker,
                    button
                }
            };
        }
    }
}

