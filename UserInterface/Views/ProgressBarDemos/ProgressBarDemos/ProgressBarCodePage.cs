﻿namespace ProgressBarDemos
{
    public class ProgressBarCodePage : ContentPage
    {
        ProgressBar defaultProgressBar;
        ProgressBar styledProgressBar;
        double progress;

        public ProgressBarCodePage()
        {
            Title = "ProgressBar Code Demo";
            Padding = 10;

            defaultProgressBar = new ProgressBar
            {
                WidthRequest = 500,
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.Center
            };

            styledProgressBar = new ProgressBar
            {
                ProgressColor = Colors.Orange,
                WidthRequest = 500,
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.Center
            };

            var progressButton = new Button
            {
                Text = "Click to Progress",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };

            progressButton.Clicked += OnButtonClicked;

            Content = new StackLayout
            {
                Children =
                {
                    defaultProgressBar,
                    styledProgressBar,
                    progressButton
                }
            };
        }

        async void OnButtonClicked(object sender, EventArgs e)
        {
            progress += 0.2;

            if (progress > 1)
            {
                progress = 0;
            }

            // directly set the new progress value
            defaultProgressBar.Progress = progress;

            // animate to the new value over 750 milliseconds using Linear easing
            await styledProgressBar.ProgressTo(progress, 750, Easing.Linear);
        }
    }
}