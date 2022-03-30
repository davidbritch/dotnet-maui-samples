using Microsoft.Maui.Controls.PlatformConfiguration;
using Microsoft.Maui.Controls.PlatformConfiguration.iOSSpecific;

namespace PlatformSpecifics
{
    public class iOSDatePickerPageCS : ContentPage
    {
        public iOSDatePickerPageCS()
        {
            Microsoft.Maui.Controls.DatePicker datePicker = new Microsoft.Maui.Controls.DatePicker
            {
                MinimumDate = new DateTime(2020,1,1),
                MaximumDate = new DateTime(2020,12,31)
            };

            Button button = new Button
            {
                Text = "Toggle DatePicker UpdateMode"
            };
            button.Clicked += (sender, e) =>
            {
                switch (datePicker.On<iOS>().UpdateMode())
                {
                    case UpdateMode.Immediately:
                        datePicker.On<iOS>().SetUpdateMode(UpdateMode.WhenFinished);
                        break;
                    case UpdateMode.WhenFinished:
                        datePicker.On<iOS>().SetUpdateMode(UpdateMode.Immediately);
                        break;
                }
            };
            datePicker.On<iOS>().SetUpdateMode(UpdateMode.WhenFinished);

            Title = "DatePicker UpdateMode";
            Content = new StackLayout
            {
                Margin = new Thickness(10),
                Children =
                {
                    datePicker,
                    button
                }
            };
        }
    }
}
