using System.Diagnostics;
using Microsoft.Maui.Controls.PlatformConfiguration;
using Microsoft.Maui.Controls.PlatformConfiguration.AndroidSpecific;
using Microsoft.Maui.Controls.PlatformConfiguration.AndroidSpecific.AppCompat;

namespace PlatformSpecifics
{
	public class AndroidLifecycleEventsPageCS : ContentPage
	{
		public AndroidLifecycleEventsPageCS()
		{
			Microsoft.Maui.Controls.Application.Current.On<Microsoft.Maui.Controls.PlatformConfiguration.Android>()
				   .UseWindowSoftInputModeAdjust(WindowSoftInputModeAdjust.Resize)
				   .SendDisappearingEventOnPause(false)
				   .SendAppearingEventOnResume(false)
				   .ShouldPreserveKeyboardOnResume(false);

			var button = new Microsoft.Maui.Controls.Button { Text = "Toggle Pause and Resume Events" };
			button.Clicked += (sender, e) =>
			{
				Microsoft.Maui.Controls.Application.Current.On<Microsoft.Maui.Controls.PlatformConfiguration.Android>()
					   .SendDisappearingEventOnPause(!Microsoft.Maui.Controls.Application.Current.On<Microsoft.Maui.Controls.PlatformConfiguration.Android>().GetSendDisappearingEventOnPause())
					   .SendAppearingEventOnResume(!Microsoft.Maui.Controls.Application.Current.On<Microsoft.Maui.Controls.PlatformConfiguration.Android>().GetSendAppearingEventOnResume())
					   .ShouldPreserveKeyboardOnResume(!Microsoft.Maui.Controls.Application.Current.On<Microsoft.Maui.Controls.PlatformConfiguration.Android>().GetShouldPreserveKeyboardOnResume());
			};
			Title = "Pause/Resume Lifecycle Events";
			Content = new StackLayout
			{
				Margin = new Thickness(20),
				Children = {
					new Label { Text = "Pause the app and then resume it. If the pause and resume events are disabled, the OnAppearing and OnDisappearing overrides won't fire.", HorizontalOptions = LayoutOptions.Center },
					button
				}
			};
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
