using ControlGallery.Drawables;
using Microsoft.Maui.Controls;

namespace ControlGallery.Views.Code
{
    public class GraphicsViewDemoPage : ContentPage
    {
        public GraphicsViewDemoPage()
        {
            Label header = new Label
            {
                Text = "Label",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            GraphicsView graphicsView = new GraphicsView
            {
                Drawable = new GraphicsDrawable(),
                HeightRequest = 300,
                WidthRequest = 400
            };

            VerticalStackLayout verticalStackLayout = new VerticalStackLayout { Spacing = 6 };
            verticalStackLayout.Add(header);
            verticalStackLayout.Add(graphicsView);

            // Build the page.
            Title = "GraphicsView demo";
            Content = verticalStackLayout;
        }
    }
}