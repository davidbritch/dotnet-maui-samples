using Microsoft.Maui.Controls.PlatformConfiguration;
using Microsoft.Maui.Controls.PlatformConfiguration.AndroidSpecific;

namespace PlatformSpecifics
{
	public class AndroidSoftInputModeAdjustPageCS : ContentPage
	{
		public AndroidSoftInputModeAdjustPageCS()
		{
			Title = "Soft Input Mode Adjust";

			var panButton = new Microsoft.Maui.Controls.Button { Text = "Pan" };
			panButton.Clicked += OnPanButtonClicked;
			var resizeButton = new Microsoft.Maui.Controls.Button { Text = "Resize " };
			resizeButton.Clicked += OnResizeButtonClicked;

			Content = new StackLayout
			{
				Margin = new Thickness(20),
				Children =
				{
					new StackLayout
					{
						Orientation = StackOrientation.Horizontal,
						HorizontalOptions = LayoutOptions.Center,
						Children = { panButton, resizeButton }
					},
					new Microsoft.Maui.Controls.Entry { Placeholder = "Enter text here", VerticalOptions = LayoutOptions.End }
				}
			};
		}

		void OnPanButtonClicked(object sender, EventArgs e)
		{
			App.Current.On<Microsoft.Maui.Controls.PlatformConfiguration.Android>().UseWindowSoftInputModeAdjust(WindowSoftInputModeAdjust.Pan);
		}

		void OnResizeButtonClicked(object sender, EventArgs e)
		{
			App.Current.On<Microsoft.Maui.Controls.PlatformConfiguration.Android>().UseWindowSoftInputModeAdjust(WindowSoftInputModeAdjust.Resize);
		}
	}
}
