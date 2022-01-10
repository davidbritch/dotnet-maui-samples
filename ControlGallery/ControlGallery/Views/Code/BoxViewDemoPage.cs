using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;

namespace ControlGallery.Views.Code
{
    class BoxViewDemoPage : ContentPage
    {
        public BoxViewDemoPage()
        {
            Label header = new Label
            {
                Text = "BoxView",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            BoxView boxView = new BoxView
            {
                Color = Colors.SkyBlue,
                WidthRequest = 150,
                HeightRequest = 150,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            // Build the page.
            Title = "BoxView Demo";
            Content = new StackLayout
            {
                Children = 
                {
                    header,
                    boxView
                }
            };
        }
    }
}
