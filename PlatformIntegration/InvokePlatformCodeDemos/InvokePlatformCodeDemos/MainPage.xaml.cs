using Microsoft.Maui.Controls;
using InvokePlatformCodeDemos.Services;

namespace InvokePlatformCodeDemos
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        protected override void OnAppearing()
        {
            base.OnAppearing();

			DeviceOrientationService deviceOrientationService = new DeviceOrientationService();
			DeviceOrientation orientation = deviceOrientationService.GetOrientation();

			orientationLabel.Text = orientation.ToString();
        }
    }
}
