﻿namespace ProgressBarDemos
{
    public partial class ProgressBarXamlPage : ContentPage
    {
        double progress;

        public ProgressBarXamlPage()
        {
            InitializeComponent();
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