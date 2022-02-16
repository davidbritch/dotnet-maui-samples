using System;
using Microsoft.Maui.Controls;

namespace ControlGallery.Views.Code
{
    public class ImageButtonDemoPage : ContentPage
    {
        Label label;
        int clickTotal = 0;

        public ImageButtonDemoPage()
        {
            Label header = new Label
            {
                Text = "ImageButton",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            ImageButton imageButton = new ImageButton
            {
                Source = "dotnet_bot.png",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };
            imageButton.Clicked += OnImageButtonClicked;

            label = new Label
            {
                Text = "0 ImageButton clicks",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };

            // Build the page.
            Title = "ImageButton Demo";
            Content = new StackLayout
            {
                Children =
                {
                    header,
                    imageButton,
                    label
                }
            };
        }

        void OnImageButtonClicked(object sender, EventArgs e)
        {
            clickTotal += 1;
            label.Text = $"{clickTotal} ImageButton click{(clickTotal == 1 ? "" : "s")}";
        }
    }
}
