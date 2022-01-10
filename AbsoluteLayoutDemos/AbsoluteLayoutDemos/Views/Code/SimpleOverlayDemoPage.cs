using System;
using Microsoft.Maui.Controls;
using Microsoft.Maui;
using Microsoft.Maui.Graphics;
using Microsoft.Maui.Layouts;

namespace AbsoluteLayoutDemos.Views.Code
{
    public class SimpleOverlayDemoPage : ContentPage
    {
        ContentView overlay;
        ProgressBar progressBar;

        public SimpleOverlayDemoPage()
        {
            Button button = new Button { Text = "Simulate 5-second work item" };
            button.Clicked += OnButtonClicked;

            StackLayout stackLayout = new StackLayout
            {
                Margin = new Thickness(20),
                Children =
                {
                    new Label { Text = "This might be a page of UI objects except that the only functional UI object on the page is a Button." },
                    button
                }
            };
            AbsoluteLayout.SetLayoutBounds(stackLayout, new Rectangle(0, 0, 1, 1));
            AbsoluteLayout.SetLayoutFlags(stackLayout, AbsoluteLayoutFlags.All);

            progressBar = new ProgressBar
            {
                Margin = new Thickness(20),
                VerticalOptions = LayoutOptions.Center
            };

            overlay = new ContentView
            {
                BackgroundColor = Color.FromArgb("#C0808080"),
                IsVisible = false,
                Content = progressBar
            };
            AbsoluteLayout.SetLayoutBounds(overlay, new Rectangle(0, 0, 1, 1));
            AbsoluteLayout.SetLayoutFlags(overlay, AbsoluteLayoutFlags.All);

            AbsoluteLayout absoluteLayout = new AbsoluteLayout
            {
                Children =
                {
                    stackLayout,
                    overlay
                }
            };

            Title = "Simple overlay demo";
            Content = absoluteLayout;
        }

        void OnButtonClicked(object sender, EventArgs e)
        {
            // Show overlay with ProgressBar
            overlay.IsVisible = true;

            TimeSpan duration = TimeSpan.FromSeconds(5);
            DateTime now = DateTime.Now;

            Device.StartTimer(TimeSpan.FromSeconds(0.1), () =>
            {
                double progress = (DateTime.Now - now).TotalMilliseconds / duration.TotalMilliseconds;
                progressBar.Progress = progress;
                bool continueTimer = progress < 1;

                if (!continueTimer)
                {
                    overlay.IsVisible = false;
                }
                return continueTimer;
            });
        }
    }
}

