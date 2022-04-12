using Microsoft.Maui.Controls.Shapes;
using GradientStop = Microsoft.Maui.Controls.GradientStop;

namespace BorderDemo;

public class MainPageCode : ContentPage
{
    public MainPageCode()
    {
        VerticalStackLayout verticalStackLayout = new VerticalStackLayout
        {
            Margin = new Thickness(20),
            Spacing = 20
        };

        Border border = new Border
        {
            Stroke = Color.FromArgb("#C49B33"),
            Background = Color.FromArgb("#2B0B98"),
            StrokeThickness = 4,
            Padding = new Thickness(16, 8),
            HorizontalOptions = LayoutOptions.Center,
            StrokeShape = new RoundRectangle
            {
                CornerRadius = new CornerRadius(40, 0, 0, 40)
            },
            Content = new Label
            {
                Text = ".NET MAUI",
                TextColor = Colors.White,
                FontSize = 18,
                FontAttributes = FontAttributes.Bold
            }
        };

        Border gradientBorder = new Border
        {
            StrokeThickness = 4,
            Background = Color.FromArgb("#2B0B98"),
            Padding = new Thickness(16, 8),
            HorizontalOptions = LayoutOptions.Center,
            StrokeShape = new RoundRectangle
            {
                CornerRadius = new CornerRadius(40, 0, 0, 40)
            },
            Stroke = new LinearGradientBrush
            {
                EndPoint = new Point(0, 1),
                GradientStops = new GradientStopCollection
                {
                    new GradientStop { Color = Colors.Orange, Offset = 0.1f },
                    new GradientStop { Color = Colors.Brown, Offset = 1.0f }
                },
            },
            Content = new Label
            {
                Text = ".NET MAUI",
                TextColor = Colors.White,
                FontSize = 18,
                FontAttributes = FontAttributes.Bold
            }
        };

        verticalStackLayout.Add(border);
        verticalStackLayout.Add(gradientBorder);
        Content = verticalStackLayout;
    }
}
