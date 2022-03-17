using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;
using Microsoft.Maui;
using Microsoft.Maui.Controls.Compatibility;

namespace RelativeLayoutDemos.Views.Code
{
    public class StylishHeaderDemoPage : ContentPage
    {
        public StylishHeaderDemoPage()
        {
            RelativeLayout relativeLayout = new RelativeLayout
            {
                Margin = new Thickness(20)
            };

            relativeLayout.Children.Add(new BoxView
            {
                Color = Colors.Silver
            }, () => new Rect(0, 10, 200, 5));

            relativeLayout.Children.Add(new BoxView
            {
                Color = Colors.Silver
            }, () => new Rect(0, 20, 200, 5));

            relativeLayout.Children.Add(new BoxView
            {
                Color = Colors.Silver
            }, () => new Rect(10, 0, 5, 65));

            relativeLayout.Children.Add(new BoxView
            {
                Color = Colors.Silver
            }, () => new Rect(20, 0, 5, 65));

            relativeLayout.Children.Add(new Label
            {
                Text = "Stylish Header",
                FontSize = 24
            }, Constraint.Constant(30), Constraint.Constant(25));

            relativeLayout.Children.Add(new Label
            {
                FormattedText = new FormattedString
                {
                    Spans =
                    {
                        new Span { Text = "Although "},
                        new Span { Text = "RelativeLayout", FontAttributes = FontAttributes.Italic },
                        new Span { Text = " is usually employed for purposes other than the display of text using a " },
                        new Span { Text = "Label", FontAttributes = FontAttributes.Italic },
                        new Span { Text = ", obviously it can be used in that way. The text continues to wrap nicely within the bounds of the container and any margin that might be applied." }
                    }
                }
            }, Constraint.Constant(0), Constraint.Constant(80));

            Title = "Stylish header demo";
            Content = relativeLayout;
        }
    }
}

