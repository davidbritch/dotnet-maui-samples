using System.Collections.Generic;
using Microsoft.Maui.Controls.PlatformConfiguration;
using Microsoft.Maui.Controls.PlatformConfiguration.iOSSpecific;

namespace PlatformSpecifics
{
    public class iOSPickerPageCS : ContentPage
    {
        public iOSPickerPageCS()
        {
            var monkeyList = new List<string>();
            monkeyList.Add("Baboon");
            monkeyList.Add("Capuchin Monkey");
            monkeyList.Add("Blue Monkey");
            monkeyList.Add("Squirrel Monkey");
            monkeyList.Add("Golden Lion Tamarin");
            monkeyList.Add("Howler Monkey");
            monkeyList.Add("Japanese Macaque");

            var picker = new Microsoft.Maui.Controls.Picker { Title = "Select a monkey" };
            picker.ItemsSource = monkeyList;

            var button = new Button { Text = "Toggle Picker UpdateMode" };
            button.Clicked += (sender, e) =>
            {
                switch (picker.On<iOS>().UpdateMode())
                {
                    case UpdateMode.Immediately:
                        picker.On<iOS>().SetUpdateMode(UpdateMode.WhenFinished);
                        break;
                    case UpdateMode.WhenFinished:
                        picker.On<iOS>().SetUpdateMode(UpdateMode.Immediately);
                        break;
                }
            };

            picker.On<iOS>().SetUpdateMode(UpdateMode.WhenFinished);

            Title = "Picker UpdateMode";
            Content = new StackLayout
            {
                Margin = new Thickness(20),
                Children = {
                    picker, button
                }
            };
        }
    }
}
