using System.Diagnostics;
using Microsoft.Maui.Controls.PlatformConfiguration;
using Microsoft.Maui.Controls.PlatformConfiguration.AndroidSpecific.AppCompat;

namespace PlatformSpecifics
{
	public partial class AndroidLifecycleEventsPage : ContentPage
	{
		public AndroidLifecycleEventsPage()
		{
			InitializeComponent();
		}

		void OnButtonClicked(object sender, EventArgs e)
		{
			Microsoft.Maui.Controls.Application.Current.On<Microsoft.Maui.Controls.PlatformConfiguration.Android>()
				   .SendDisappearingEventOnPause(!Microsoft.Maui.Controls.Application.Current.On<Microsoft.Maui.Controls.PlatformConfiguration.Android>().GetSendDisappearingEventOnPause())
				   .SendAppearingEventOnResume(!Microsoft.Maui.Controls.Application.Current.On<Microsoft.Maui.Controls.PlatformConfiguration.Android>().GetSendAppearingEventOnResume())
				   .ShouldPreserveKeyboardOnResume(!Microsoft.Maui.Controls.Application.Current.On<Microsoft.Maui.Controls.PlatformConfiguration.Android>().GetShouldPreserveKeyboardOnResume());
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();
			Debug.WriteLine("\r\n\t\tOnAppearing\r\n");
		}

		protected override void OnDisappearing()
		{
			base.OnDisappearing();
			Debug.WriteLine("\r\n\t\tOnDisappearing\r\n");
		}
	}
}
