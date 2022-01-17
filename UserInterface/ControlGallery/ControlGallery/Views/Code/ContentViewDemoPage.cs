using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;

namespace ControlGallery.Views.Code
{
    class ContentViewDemoPage : ContentPage
    {
        public ContentViewDemoPage()
        {
            Label header = new Label
            {
                Text = "ContentView",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            ContentView contentView = new ContentView
            {
                BackgroundColor = Colors.Aqua,
                Margin = new Thickness(10),
                Padding = new Thickness(25),
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                Content = new Label
                {
                    Text = "The ContentView (colored aqua in this " +
                           "example) might not seem very useful " +
                           "because it can have a single child " +
                           "(in this example a Label) and doesn't " +
                           "do much else. But ContentView is sometimes a " +
                           "convenient way of providing a background " +
                           "color or giving a little margin to its " +
                           "child through its own Padding property.",
                    TextColor = Colors.Purple
                }
            };

            // Build the page.
            Title = "ContentView Demo";
            Content = new StackLayout
            {
                Children = 
                {
                    header,
                    contentView
                }
            };
        }
    }
}
