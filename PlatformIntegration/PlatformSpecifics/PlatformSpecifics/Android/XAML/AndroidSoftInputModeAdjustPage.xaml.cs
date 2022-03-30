using Microsoft.Maui.Controls.PlatformConfiguration;
using Microsoft.Maui.Controls.PlatformConfiguration.AndroidSpecific;

namespace PlatformSpecifics
{
	public partial class AndroidSoftInputModeAdjustPage : ContentPage
	{
		public AndroidSoftInputModeAdjustPage()
		{
			InitializeComponent();
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
