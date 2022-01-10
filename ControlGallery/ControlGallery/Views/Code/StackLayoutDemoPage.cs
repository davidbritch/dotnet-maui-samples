using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace ControlGallery.Views.Code
{
    class StackLayoutDemoPage : ContentPage
    {
        public StackLayoutDemoPage()
        {
            Label header = new Label
            {
                Text = "StackLayout",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            StackLayout stackLayout = new StackLayout
            {
                Spacing = 0,
                VerticalOptions = LayoutOptions.FillAndExpand,
                Margin = new Thickness(10)
            };

            stackLayout.Add(new Label
            {
                Text = "StackLayout",
                HorizontalOptions = LayoutOptions.Start
            });
            stackLayout.Add(new Label
            {
                Text = "stacks its children",
                HorizontalOptions = LayoutOptions.Center
            });
            stackLayout.Add(new Label
            {
                Text = "vertically",
                HorizontalOptions = LayoutOptions.End
            });
            stackLayout.Add(new Label
            {
                Text = "by default,",
                HorizontalOptions = LayoutOptions.Center
            });
            stackLayout.Add(new Label
            {
                Text = "but horizontal placement",
                HorizontalOptions = LayoutOptions.Start
            });
            stackLayout.Add(new Label
            {
                Text = "can be controlled with",
                HorizontalOptions = LayoutOptions.Center
            });
            stackLayout.Add(new Label
            {
                Text = "the HorizontalOptions property.",
                HorizontalOptions = LayoutOptions.End
            });
            stackLayout.Add(new Label
            {
                Text = "An Expand option allows one or more children " +
                               "to occupy the an area within the remaining " +
                               "space of the StackLayout after it's been sized " +
                               "to the height of its parent.",
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.End
            });

            StackLayout horizontalStackLayout = new StackLayout
            {
                Orientation = StackOrientation.Horizontal
            };
            horizontalStackLayout.Add(new Label
            {
                Text = "Stacking",
            });
            horizontalStackLayout.Add(new Label
            {
                Text = "can also be",
                HorizontalOptions = LayoutOptions.CenterAndExpand
            });
            horizontalStackLayout.Add(new Label
            {
                Text = "horizontal.",
            });

            stackLayout.Add(horizontalStackLayout);

            StackLayout rootStackLayout = new StackLayout();
            rootStackLayout.Add(header);
            rootStackLayout.Add(horizontalStackLayout);

            // Build the page.
            Title = "StackLayout Demo";
            Content = rootStackLayout;
        }
    }
}
