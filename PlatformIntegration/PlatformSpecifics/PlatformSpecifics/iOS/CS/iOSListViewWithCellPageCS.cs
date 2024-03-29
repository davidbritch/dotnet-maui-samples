﻿using Microsoft.Maui.Controls.PlatformConfiguration;
using Microsoft.Maui.Controls.PlatformConfiguration.iOSSpecific;

namespace PlatformSpecifics
{
    public class iOSListViewWithCellPageCS : ContentPage
    {
        public iOSListViewWithCellPageCS()
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

            var groupHeaderTemplate = new DataTemplate(() =>
            {
                var label = new Label { Margin = new Thickness(10, 10), FontAttributes = FontAttributes.Bold };
                label.SetBinding(Label.TextProperty, "Key");

                var viewCell = new ViewCell { View = label };
                viewCell.On<iOS>().SetDefaultBackgroundColor(Colors.Teal);
                return viewCell;
            });

            var listView = new Microsoft.Maui.Controls.ListView { IsGroupingEnabled = true, ItemTemplate = personDataTemplate, GroupHeaderTemplate = groupHeaderTemplate };
            listView.SetBinding(ItemsView<Microsoft.Maui.Controls.Cell>.ItemsSourceProperty, "GroupedEmployees");
            listView.On<iOS>()
                .SetSeparatorStyle(SeparatorStyle.FullWidth)
                .SetRowAnimationsEnabled(false)
                .SetGroupHeaderStyle(GroupHeaderStyle.Grouped);

            Title = "ListView/Cell Platform-Specifics";
            Content = new StackLayout
            {
                Margin = new Thickness(20),
                Children = { listView }
            };
            BindingContext = new ListViewViewModel(20);
        }
    }
}
