using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Shapes;
using Microsoft.Maui.Graphics;

namespace ControlGallery.Views.Code
{
    public class BorderDemoPage : ContentPage
    {
        public BorderDemoPage()
        {
            Label header = new Label
            {
                Text = "Border",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            Border border = new Border
            {
                Stroke = Color.FromArgb("#C49B33"),
                StrokeThickness = 4,
                StrokeShape = new RoundRectangle
                {
                    CornerRadius = new CornerRadius(40,0,0,40)
                },
                Background = Color.FromArgb("#2B0B98"),
                Padding = new Thickness(16, 8),
                HorizontalOptions = LayoutOptions.Center,
                Content = new Label
                {
                    Text = ".NET MAUI",
                    TextColor = Colors.White,
                    FontSize = 18,
                    FontAttributes = FontAttributes.Bold
                }
            };

            VerticalStackLayout verticalStackLayout = new VerticalStackLayout { Spacing = 6 };
            verticalStackLayout.Add(header);
            verticalStackLayout.Add(border);

            // Build the page.
            Title = "Border Demo";
            Content = verticalStackLayout;
        }
    }
}
