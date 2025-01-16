using Microsoft.Maui.Controls.PlatformConfiguration.AndroidSpecific;

namespace PlatformSpecifics
{
    public class AndroidListViewFastScrollPageCS : ContentPage
    {
        public AndroidListViewFastScrollPageCS()
        {
            var personDataTemplate = new DataTemplate(() =>
            {
                var grid = new Grid();
                grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(0.7, GridUnitType.Star) });
                grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(0.3, GridUnitType.Star) });

                var nameLabel = new Label();
                var ageLabel = new Label { HorizontalOptions = LayoutOptions.End };

                nameLabel.SetBinding(Label.TextProperty, static (Person p) => p.Name);
                ageLabel.SetBinding(Label.TextProperty, static (Person p) => p.Age);

                grid.Add(nameLabel);
                grid.Add(ageLabel, 1, 0);

                return new Microsoft.Maui.Controls.ViewCell { View = grid };
            });

            var listView = new Microsoft.Maui.Controls.ListView { IsGroupingEnabled = true, ItemTemplate = personDataTemplate };
            listView.SetBinding(ItemsView<Cell>.ItemsSourceProperty, static (ListViewViewModel vm) => vm.GroupedEmployees);
            listView.GroupDisplayBinding = Binding.Create(static (Grouping<char, Person> g) => g.Key);
            listView.On<Microsoft.Maui.Controls.PlatformConfiguration.Android>().SetIsFastScrollEnabled(true);

            var button = new Microsoft.Maui.Controls.Button { Text = "Toggle FastScroll" };
            button.Clicked += (sender, e) => { listView.On<Microsoft.Maui.Controls.PlatformConfiguration.Android>().SetIsFastScrollEnabled(!listView.On<Microsoft.Maui.Controls.PlatformConfiguration.Android>().IsFastScrollEnabled()); };

            Title = "ListView FastScroll";
            Content = new StackLayout
            {
                Margin = new Thickness(20),
                Children = {
                    button,
                    listView
                }
            };
            BindingContext = new ListViewViewModel();
        }
    }
}
