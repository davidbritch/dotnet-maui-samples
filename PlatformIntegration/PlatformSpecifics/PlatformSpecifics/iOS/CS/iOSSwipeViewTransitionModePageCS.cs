using Microsoft.Maui.Controls.PlatformConfiguration;
using Microsoft.Maui.Controls.PlatformConfiguration.iOSSpecific;

namespace PlatformSpecifics
{
    public class iOSSwipeViewTransitionModePageCS : ContentPage
    {
        Microsoft.Maui.Controls.SwipeView swipeView;

        public iOSSwipeViewTransitionModePageCS()
        {
            StackLayout stackLayout = new StackLayout { Orientation = StackOrientation.Horizontal, HorizontalOptions = LayoutOptions.Center };
            Label label = new Label { Text = "SwipeTransitionMode: ", VerticalTextAlignment = TextAlignment.Center };
            EnumPicker enumPicker = new EnumPicker { EnumType = typeof(SwipeTransitionMode), SelectedIndex = 1 };
            enumPicker.SelectedIndexChanged += OnSwipeViewTransitionModeChanged;
            stackLayout.Add(label);
            stackLayout.Add(enumPicker);

            swipeView = new Microsoft.Maui.Controls.SwipeView();
            SwipeItem swipeItem = new SwipeItem
            {
                Text = "Delete",
                IconImageSource = "delete.png",
                BackgroundColor = Colors.LightPink
            };
            swipeItem.Invoked += OnDeleteSwipeItemInvoked;
            swipeView.LeftItems = new SwipeItems { swipeItem };

            Grid grid = new Grid { HeightRequest = 60, WidthRequest = 300, BackgroundColor = Colors.LightGray };
            Label gridLabel = new Label { Text = "Swipe right", HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center };
            grid.Add(gridLabel);

            swipeView.Content = grid;
            swipeView.On<iOS>().SetSwipeTransitionMode(SwipeTransitionMode.Drag);

            Title = "SwipeView SwipeTransitionMode";
            Content = new StackLayout
            {
                Margin = new Thickness(20),
                Children = { stackLayout, swipeView }
            };
        }

        void OnSwipeViewTransitionModeChanged(object sender, EventArgs e)
        {
            SwipeTransitionMode transitionMode = (SwipeTransitionMode)(sender as EnumPicker).SelectedItem;
            swipeView.On<iOS>().SetSwipeTransitionMode(transitionMode);
        }

        async void OnDeleteSwipeItemInvoked(object sender, EventArgs e)
        {
            await DisplayAlert("SwipeView", "Delete invoked.", "OK");
        }
    }
}
