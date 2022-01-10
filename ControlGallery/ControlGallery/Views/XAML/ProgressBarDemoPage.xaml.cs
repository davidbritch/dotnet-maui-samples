using System;
using Microsoft.Maui.Controls;

namespace ControlGallery.Views.XAML
{
    public partial class ProgressBarDemoPage : ContentPage
    {
        bool isActiveWindow;

        public ProgressBarDemoPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            isActiveWindow = true;
            Device.StartTimer(TimeSpan.FromSeconds(0.1), TimerCallback);
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            isActiveWindow = false;
        }

        bool TimerCallback()
        {
            progressBar.Progress += 0.01;
            return isActiveWindow || progressBar.Progress == 1;
        }
    }
}