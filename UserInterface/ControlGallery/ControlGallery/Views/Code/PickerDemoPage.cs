using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;
using System.Collections.Generic;

namespace ControlGallery.Views.Code
{
    class PickerDemoPage : ContentPage
    {
        // Dictionary to get Color from color name.
        Dictionary<string, Color> nameToColor = new Dictionary<string, Color>
        {
            { "Aqua", Colors.Aqua },         { "Black", Colors.Black },
            { "Blue", Colors.Blue },         { "Fuchsia", Colors.Fuchsia },
            { "Gray", Colors.Gray },         { "Green", Colors.Green },
            { "Lime", Colors.Lime },         { "Maroon", Colors.Maroon },
            { "Navy", Colors.Navy },         { "Olive", Colors.Olive },
            { "Purple", Colors.Purple },     { "Red", Colors.Red },
            { "Silver", Colors.Silver },     { "Teal", Colors.Teal },
            { "White", Colors.White },       { "Yellow", Colors.Yellow }
        };

        public PickerDemoPage()
        {
            Label header = new Label
            {
                Text = "Picker",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            Picker picker = new Picker
            {
                Title = "Color",
                VerticalOptions = LayoutOptions.CenterAndExpand,
                Margin = new Thickness(10, 0)
            };

            foreach (string colorName in nameToColor.Keys)
            {
                picker.Items.Add(colorName);
            }

            // Create BoxView for displaying picked Color
            BoxView boxView = new BoxView
            {
                WidthRequest = 150,
                HeightRequest = 150,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            picker.SelectedIndexChanged += (sender, args) =>
            {
                if (picker.SelectedIndex == -1)
                {
                    boxView.Color = Colors.Black;
                }
                else
                {
                    string colorName = picker.Items[picker.SelectedIndex];
                    boxView.Color = nameToColor[colorName];
                }
            };

            // Build the page.
            Title = "Picker Demo";
            Content = new StackLayout
            {
                Children = 
                {
                    header,
                    picker,
                    boxView
                }
            };

        }
    }
}
