using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Shapes = Microsoft.Maui.Controls.Shapes;

namespace ControlGallery.Views.Code
{
    public class HorizontalStackLayoutDemoPage : ContentPage
    {
        public HorizontalStackLayoutDemoPage()
        {
            Label header = new Label
            {
                Text = "HorizontalStackLayout",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            HorizontalStackLayout horizontalStackLayout = new HorizontalStackLayout { Spacing = 10 };
            horizontalStackLayout.Add(new Shapes.Rectangle { Fill = SolidColorBrush.Red, HeightRequest = 30, WidthRequest = 30 });
            horizontalStackLayout.Add(new Label { Text = "Red", FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)) });

            VerticalStackLayout verticalStackLayout = new VerticalStackLayout { Margin = new Thickness(20) };
            verticalStackLayout.Add(header);
            verticalStackLayout.Add(horizontalStackLayout);

            // Build the page.
            Title = "HorizontalStackLayout demo";
            Content = verticalStackLayout;
        }
    }
}
