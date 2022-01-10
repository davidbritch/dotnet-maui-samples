using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;

namespace ControlGallery.Views.Code
{
    class GridDemoPage : ContentPage
    {
        public GridDemoPage ()
        {
            Grid grid = new Grid
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Margin = new Thickness(10),
                RowDefinitions =
                {
                    new RowDefinition { Height = GridLength.Auto },
                    new RowDefinition { Height = GridLength.Auto },
                    new RowDefinition { Height = new GridLength (1, GridUnitType.Star) },
                    new RowDefinition { Height = new GridLength (100, GridUnitType.Absolute) }
                },
                ColumnDefinitions =
                {
                    new ColumnDefinition { Width = GridLength.Auto },
                    new ColumnDefinition { Width = new GridLength (1, GridUnitType.Star) },
                    new ColumnDefinition { Width = new GridLength (100, GridUnitType.Absolute) }
                }
            };

            Label titleLabel = new Label
            {
                Text = "Grid",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };
            Grid.SetColumnSpan(titleLabel, 3);

            grid.Add(titleLabel);
            grid.Add (new Label
            {
                Text = "Autosized cell",
                TextColor = Colors.White,
                BackgroundColor = Colors.Blue
            }, 0, 1);

            grid.Add (new BoxView
            {
                Color = Colors.Silver,
                HeightRequest = 0
            }, 1, 1);

            grid.Add (new BoxView
            {
                Color = Colors.Teal
            }, 0, 2);

            grid.Add (new Label
            {
                Text = "Leftover space",
                TextColor = Colors.Purple,
                BackgroundColor = Colors.Aqua,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center,
            }, 1, 2);

            Label twoRowSpanLabel = new Label
            {
                Text = "Span two rows (or more if you want)",
                TextColor = Colors.Yellow,
                BackgroundColor = Colors.Navy,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center
            };
            Grid.SetRowSpan(twoRowSpanLabel, 2);
            grid.Add(twoRowSpanLabel, 2, 1);

            Label twoColumnSpanLabel = new Label
            {
                Text = "Span 2 columns",
                TextColor = Colors.Blue,
                BackgroundColor = Colors.Yellow,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center
            };
            Grid.SetColumnSpan(twoColumnSpanLabel, 2);
            grid.Add(twoColumnSpanLabel, 0, 3);
            grid.Add (new Label
            {
                Text = "Fixed 100x100",
                TextColor = Colors.Aqua,
                BackgroundColor = Colors.Red,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center
            }, 2, 3);

            // Build the page.
            Title = "Grid Demo";
            Content = grid;
        }
    }
}
