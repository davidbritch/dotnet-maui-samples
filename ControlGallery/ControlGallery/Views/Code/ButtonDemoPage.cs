using System;
using Microsoft.Maui.Controls;

namespace ControlGallery.Views.Code
{
    class ButtonDemoPage : ContentPage
    {
        Label label;
        int clickTotal = 0;

        public ButtonDemoPage()
        {
            Label header = new Label
            {
                Text = "Button",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            Button button = new Button
            {
                Text = "Click Me!",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
                BorderWidth = 1,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            button.Clicked += OnButtonClicked;

            label = new Label
            {
                Text = "0 button clicks",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            // Build the page.
            Title = "Button Demo";
            Content = new StackLayout
            {
                Children = 
                {
                    header,
                    button,
                    label
                }
            };
        }

        void OnButtonClicked(object sender, EventArgs e)
        {
            clickTotal += 1;
            label.Text = String.Format("{0} button click{1}",
                                       clickTotal, clickTotal == 1 ? "" : "s");
        }
    }
}
