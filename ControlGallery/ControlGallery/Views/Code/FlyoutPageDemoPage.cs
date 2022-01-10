using ControlGallery.Models;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;

namespace ControlGallery.Views.Code
{
    class FlyoutPageDemoPage : FlyoutPage
    {
        public FlyoutPageDemoPage()
        {
            Title = "FlyoutPage Demo";

            Label header = new Label
            {
                Text = "FlyoutPage",
                FontSize = 30,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            // Assemble an array of NamedColor objects.
            NamedColor[] namedColors = {
                new NamedColor ("Aqua", Colors.Aqua),
                new NamedColor ("Black", Colors.Black),
                new NamedColor ("Blue", Colors.Blue),
                new NamedColor ("Fuchsia", Colors.Fuchsia),
                new NamedColor ("Gray", Colors.Gray),
                new NamedColor ("Green", Colors.Green),
                new NamedColor ("Lime", Colors.Lime),
                new NamedColor ("Maroon", Colors.Maroon),
                new NamedColor ("Navy", Colors.Navy),
                new NamedColor ("Olive", Colors.Olive),
                new NamedColor ("Purple", Colors.Purple),
                new NamedColor ("Red", Colors.Red),
                new NamedColor ("Silver", Colors.Silver),
                new NamedColor ("Teal", Colors.Teal),
                new NamedColor ("White", Colors.White),
                new NamedColor ("Yellow", Colors.Yellow)
            };

            // Create ListView for the master page.
            ListView listView = new ListView
            {
                ItemsSource = namedColors,
                Margin = new Thickness(10, 0)
            };

            // Create the flyout page with the ListView.
            Flyout = new ContentPage
            {
                Title = "Color List",       // Title required!
                Content = new StackLayout
                {
                    Children = {
                        header,
                        listView
                    }
                }
            };

            // Create the detail page using NamedColorPage
            NamedColorPage detailPage = new NamedColorPage(true);
            Detail = detailPage;

            // Define a selected handler for the ListView.
            listView.ItemSelected += (sender, args) =>
            {
                // Set the BindingContext of the detail page.
                Detail.BindingContext = args.SelectedItem;

                // Show the detail page.
                IsPresented = false;
            };

            // Initialize the ListView selection.
            listView.SelectedItem = namedColors[0];
        }
    }
}
