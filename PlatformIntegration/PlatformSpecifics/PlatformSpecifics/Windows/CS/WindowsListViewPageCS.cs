using Microsoft.Maui.Controls.PlatformConfiguration;
using Microsoft.Maui.Controls.PlatformConfiguration.WindowsSpecific;

namespace PlatformSpecifics
{
    public class WindowsListViewPageCS : ContentPage
    {
        Microsoft.Maui.Controls.ListView _listView;
        Microsoft.Maui.Controls.Label _label;

        public WindowsListViewPageCS()
        {
			var personDataTemplate = new DataTemplate(() =>
            {
                var grid = new Grid();
                grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(0.7, GridUnitType.Star) });
                grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(0.3, GridUnitType.Star) });

                var nameLabel = new Microsoft.Maui.Controls.Label();
				var ageLabel = new Microsoft.Maui.Controls.Label { HorizontalOptions = LayoutOptions.Center };

				nameLabel.SetBinding(Microsoft.Maui.Controls.Label.TextProperty, "Name");
				ageLabel.SetBinding(Microsoft.Maui.Controls.Label.TextProperty, "Age");

                var tapGestureRecognizer = new TapGestureRecognizer();
                tapGestureRecognizer.Tapped += async (sender, e) =>
                {
                    await DisplayAlert("Tap Gesture Recognizer", "Tapped event fired.", "OK");
                };
                nameLabel.GestureRecognizers.Add(tapGestureRecognizer);

                grid.Add(nameLabel);
                grid.Add(ageLabel, 1, 0);

                return new ViewCell { View = grid };
            });

            _listView = new Microsoft.Maui.Controls.ListView { IsGroupingEnabled = true, ItemTemplate = personDataTemplate };
            _listView.SetBinding(ItemsView<Cell>.ItemsSourceProperty, "GroupedEmployees");
            _listView.GroupDisplayBinding = new Binding("Key");
            _listView.ItemTapped += async (sender, e) =>
            {
                await DisplayAlert("Item Tapped", "ItemTapped event fired.", "OK");
            };
            _listView.On<Microsoft.Maui.Controls.PlatformConfiguration.Windows>().SetSelectionMode(Microsoft.Maui.Controls.PlatformConfiguration.WindowsSpecific.ListViewSelectionMode.Inaccessible);

            var button = new Button { Text = "Toggle SelectionMode" };
            button.Clicked += (sender, e) =>
            {
                switch (_listView.On<Microsoft.Maui.Controls.PlatformConfiguration.Windows>().GetSelectionMode())
                {
                    case Microsoft.Maui.Controls.PlatformConfiguration.WindowsSpecific.ListViewSelectionMode.Accessible:
                        _listView.On<Microsoft.Maui.Controls.PlatformConfiguration.Windows>().SetSelectionMode(Microsoft.Maui.Controls.PlatformConfiguration.WindowsSpecific.ListViewSelectionMode.Inaccessible);
                        break;
                    case Microsoft.Maui.Controls.PlatformConfiguration.WindowsSpecific.ListViewSelectionMode.Inaccessible:
                        _listView.On<Microsoft.Maui.Controls.PlatformConfiguration.Windows>().SetSelectionMode(Microsoft.Maui.Controls.PlatformConfiguration.WindowsSpecific.ListViewSelectionMode.Accessible);
                        break;
                }
                UpdateLabel();
            };

            _label = new Microsoft.Maui.Controls.Label { HorizontalOptions = LayoutOptions.Center };

            Title = "ListView Selection Mode";
            Content = new StackLayout
            {
                Margin = new Thickness(20),
                Children = { _listView, button, _label }
            };
			BindingContext = new ListViewViewModel();
            UpdateLabel();
        }

        void UpdateLabel()
        {
            _label.Text = $"ListView SelectionMode: {_listView.On<Microsoft.Maui.Controls.PlatformConfiguration.Windows>().GetSelectionMode()}";
        }
    }
}
