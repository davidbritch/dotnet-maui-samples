using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Shapes = Microsoft.Maui.Controls.Shapes;

namespace ControlGallery.Views.Code
{
    public class VerticalStackLayoutDemoPage : ContentPage
    {
        public VerticalStackLayoutDemoPage()
        {
            Label header = new Label
            {
                Text = "VerticalStackLayout",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            VerticalStackLayout verticalStackLayout = new VerticalStackLayout
            {
                Margin = new Thickness(20),
                Spacing = 10
            };

            verticalStackLayout.Add(header);
            verticalStackLayout.Add(new Label { Text = "Primary colors" });
            verticalStackLayout.Add(new Shapes.Rectangle { Fill = SolidColorBrush.Red, HeightRequest = 30, WidthRequest = 300 });
            verticalStackLayout.Add(new Shapes.Rectangle { Fill = SolidColorBrush.Yellow, HeightRequest = 30, WidthRequest = 300 });
            verticalStackLayout.Add(new Shapes.Rectangle { Fill = SolidColorBrush.Blue, HeightRequest = 30, WidthRequest = 300 });
            verticalStackLayout.Add(new Label { Text = "Secondary colors" });
            verticalStackLayout.Add(new Shapes.Rectangle { Fill = SolidColorBrush.Green, HeightRequest = 30, WidthRequest = 300 });
            verticalStackLayout.Add(new Shapes.Rectangle { Fill = SolidColorBrush.Orange, HeightRequest = 30, WidthRequest = 300 });
            verticalStackLayout.Add(new Shapes.Rectangle { Fill = SolidColorBrush.Purple, HeightRequest = 30, WidthRequest = 300 });

            // Build the page.
            Title = "VerticalStackLayout Demo";
            Content = verticalStackLayout;
        }
    }
}
