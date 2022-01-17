using ControlGallery.Models;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;
using System;
using System.Collections.Generic;

namespace ControlGallery.Views.Code
{
    class ListViewDemoPage : ContentPage
    {
        public ListViewDemoPage()
        {
            Label header = new Label
            {
                Text = "ListView",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            // Define some data.
            List<Person> people = new List<Person>
            {
                new Person("Abigail", new DateTime(1975, 1, 15), Colors.Aqua),
                new Person("Bob", new DateTime(1976, 2, 20), Colors.Black),
                new Person("Cathy", new DateTime(1977, 3, 10), Colors.Blue),
                new Person("David", new DateTime(1978, 4, 25), Colors.Fuchsia),
                new Person("Eugenie", new DateTime(1979, 5, 5), Colors.Gray),
                new Person("Freddie", new DateTime(1980, 6, 30), Colors.Green),
                new Person("Greta", new DateTime(1981, 7, 15), Colors.Lime),
                new Person("Harold", new DateTime(1982, 8, 10), Colors.Maroon),
                new Person("Irene", new DateTime(1983, 9, 25), Colors.Navy),
                new Person("Jonathan", new DateTime(1984, 10, 10), Colors.Olive),
                new Person("Kathy", new DateTime(1985, 11, 20), Colors.Purple),
                new Person("Larry", new DateTime(1986, 12, 5), Colors.Red),
                new Person("Monica", new DateTime(1975, 1, 5), Colors.Silver),
                new Person("Nick", new DateTime(1976, 2, 10), Colors.Teal),
                new Person("Olive", new DateTime(1977, 3, 20), Colors.White),
                new Person("Pendleton", new DateTime(1978, 4, 10), Colors.Yellow),
                new Person("Queenie", new DateTime(1979, 5, 15), Colors.Aqua),
                new Person("Rob", new DateTime(1980, 6, 30), Colors.Blue),
                new Person("Sally", new DateTime(1981, 7, 5), Colors.Fuchsia),
                new Person("Timothy", new DateTime(1982, 8, 30), Colors.Green),
                new Person("Uma", new DateTime(1983, 9, 10), Colors.Lime),
                new Person("Victor", new DateTime(1984, 10, 20), Colors.Maroon),
                new Person("Wendy", new DateTime(1985, 11, 5), Colors.Navy),
                new Person("Xavier", new DateTime(1986, 12, 30), Colors.Olive),
                new Person("Yvonne", new DateTime(1987, 1, 10), Colors.Purple),
                new Person("Zachary", new DateTime(1988, 2, 5), Colors.Red)
            };

            // Create the ListView.
            ListView listView = new ListView
            {
                // Source of data items.
                ItemsSource = people,

                // Define template for displaying each item.
                // (Argument of DataTemplate constructor is called for 
                //      each item; it must return a Cell derivative.)
                ItemTemplate = new DataTemplate(() =>
                {
                    // Create views with bindings for displaying each property.
                    Label nameLabel = new Label();
                    nameLabel.SetBinding(Label.TextProperty, "Name");

                    Label birthdayLabel = new Label();
                    birthdayLabel.SetBinding(Label.TextProperty,
                        new Binding("Birthday", BindingMode.OneWay,
                                    null, null, "Born {0:d}"));

                    BoxView boxView = new BoxView();
                    boxView.SetBinding(BoxView.ColorProperty, "FavoriteColor");

                    // Return an assembled ViewCell.
                    return new ViewCell
                    {
                        View = new StackLayout
                        {
                            Padding = new Thickness(0, 5),
                            Orientation = StackOrientation.Horizontal,
                            Children =
                            {
                                boxView,
                                new StackLayout
                                {
                                    VerticalOptions = LayoutOptions.Center,
                                    Spacing = 0,
                                    Children =
                                    {
                                        nameLabel,
                                        birthdayLabel
                                    }
                                }
                            }
                        }
                    };
                }),

                Margin = new Thickness(10, 0)
            };

            // Build the page.
            Title = "ListView Demo";
            Content = new StackLayout
            {
                Children = 
                {
                    header,
                    listView
                }
            };
        }
    }
}

