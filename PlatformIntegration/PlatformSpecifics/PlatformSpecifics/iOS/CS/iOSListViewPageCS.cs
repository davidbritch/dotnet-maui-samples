using Microsoft.Maui.Controls.PlatformConfiguration;
using Microsoft.Maui.Controls.PlatformConfiguration.iOSSpecific;

namespace PlatformSpecifics
{
    public class iOSListViewPageCS : ContentPage
    {
        public iOSListViewPageCS()
        {
			var personDataTemplate = new DataTemplate(() =>
            {
                var grid = new Grid();
                grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(0.7, GridUnitType.Star) });
                grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(0.3, GridUnitType.Star) });

                var nameLabel = new Label();
                var ageLabel = new Label { HorizontalOptions = LayoutOptions.End };

                nameLabel.SetBinding(Label.TextProperty, "Name");
                ageLabel.SetBinding(Label.TextProperty, "Age");

                grid.Add(nameLabel);
                grid.Add(ageLabel, 1, 0);

                return new ViewCell { View = grid };
            });

            var listView = new Microsoft.Maui.Controls.ListView { IsGroupingEnabled = true, ItemTemplate = personDataTemplate };
            listView.SetBinding(ItemsView<Microsoft.Maui.Controls.Cell>.ItemsSourceProperty, "GroupedEmployees");
            listView.GroupDisplayBinding = new Binding("Key");
            listView.On<iOS>()
                .SetSeparatorStyle(SeparatorStyle.FullWidth)
                .SetRowAnimationsEnabled(false)
                .SetGroupHeaderStyle(GroupHeaderStyle.Plain);

			Title = "ListView Platform-Specifics";
            Content = new StackLayout
            {
                Margin = new Thickness(20),
				Children = { listView }
            };
            BindingContext = new ListViewViewModel();
        }
    }
}
