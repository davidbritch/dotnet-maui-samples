using Microsoft.Maui.Dispatching;
using System.Diagnostics;

namespace ButtonDemos
{
    public partial class PressAndReleaseButtonPage : ContentPage
    {
        IDispatcherTimer timer;
        Stopwatch stopwatch = new Stopwatch();

        public PressAndReleaseButtonPage()
        {
            InitializeComponent();

            timer = Dispatcher.CreateTimer();
            timer.Interval = TimeSpan.FromMilliseconds(16);
            timer.Tick += (s, e) =>
            {
                label.Rotation = 360 * (stopwatch.Elapsed.TotalSeconds % 1);
            };
        }

        void OnButtonPressed(object sender, EventArgs args)
        {
            stopwatch.Start();
            timer.Start();
        }

        void OnButtonReleased(object sender, EventArgs args)
        {
            stopwatch.Stop();
            timer.Stop();
        }
    }
}