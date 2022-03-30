using Microsoft.Maui.Layouts;
using Microsoft.Maui.Controls.PlatformConfiguration.WindowsSpecific;
using RefreshPullDirection = Microsoft.Maui.Controls.PlatformConfiguration.WindowsSpecific.RefreshView.RefreshPullDirection;
using Label = Microsoft.Maui.Controls.Label;
using RefreshView = Microsoft.Maui.Controls.RefreshView;

namespace PlatformSpecifics
{
    public class WindowsRefreshViewPageCS : ContentPage
    {
        public WindowsRefreshViewPageCS()
        {
            WindowsRefreshViewPageViewModel viewModel = new WindowsRefreshViewPageViewModel();

            // Define DataTemplate.
            DataTemplate colorItemTemplate = new DataTemplate(() =>
            {
                Grid grid = new Grid
                {
                    Margin = new Thickness(5),
                    HeightRequest = 120,
                    WidthRequest = 105
                };

                BoxView boxView = new BoxView();
                boxView.SetBinding(BoxView.ColorProperty, "Color");

                Label label = new Label
                {
                    HorizontalOptions = LayoutOptions.Center,
                    VerticalOptions = LayoutOptions.Center
                };
                label.SetBinding(Label.TextProperty, "Name");

                grid.Add(boxView);
                grid.Add(label);
                return grid;
            });

            Label pullDirection = new Label
            {
                Text = "Pull Direction:",
                VerticalTextAlignment = TextAlignment.Center
            };

            EnumPicker enumPicker = new EnumPicker
            {
                EnumType = typeof(Microsoft.Maui.Controls.PlatformConfiguration.WindowsSpecific.RefreshView.RefreshPullDirection),
                SelectedIndex = 0
            };

            Label numberOfItems = new Label
            {
                HorizontalOptions = LayoutOptions.Center
            };
            numberOfItems.SetBinding(Microsoft.Maui.Controls.Label.TextProperty, "Items.Count", stringFormat: "Number of items: {0}");

            StackLayout controlsLayout = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                HorizontalOptions = LayoutOptions.Center,
                Children =
                {
                    pullDirection,
                    enumPicker
                }
            };

            FlexLayout flexLayout = new FlexLayout
            {
                Direction = FlexDirection.Row,
                Wrap = FlexWrap.Wrap,
                AlignItems = FlexAlignItems.Center,
                AlignContent = FlexAlignContent.Center
            };
            BindableLayout.SetItemsSource(flexLayout, viewModel.Items);
            BindableLayout.SetItemTemplate(flexLayout, colorItemTemplate);

            // Set the FlexLayout as the child of the ScrollView.
            ScrollView scrollView = new ScrollView
            {
                Content = flexLayout
            };

            // Set the ScrollView as the child of the RefreshView.
            RefreshView refreshView = new RefreshView
            {
                Content = scrollView,
                RefreshColor = Colors.Teal
            };
            refreshView.SetBinding(RefreshView.IsRefreshingProperty, "IsRefreshing");
            refreshView.SetBinding(RefreshView.CommandProperty, "RefreshCommand");
            refreshView.On<Microsoft.Maui.Controls.PlatformConfiguration.Windows>().SetRefreshPullDirection(RefreshPullDirection.LeftToRight);

            enumPicker.SelectedIndexChanged += (s, e) =>
            {
                refreshView.On<Microsoft.Maui.Controls.PlatformConfiguration.Windows>().SetRefreshPullDirection((RefreshPullDirection)enumPicker.SelectedItem);
            };

            // Build the page.
            Title = "RefreshView Demo";
            BindingContext = viewModel;
            Content = new StackLayout
            {
                Margin = new Thickness(10),
                Children =
                {
                    controlsLayout,
                    numberOfItems,
                    refreshView
                }
            };
        }
    }
}
