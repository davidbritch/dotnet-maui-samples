using Microsoft.Maui.Controls.PlatformConfiguration;
using Microsoft.Maui.Controls.PlatformConfiguration.iOSSpecific;

namespace PlatformSpecifics
{
	public class iOSEntryPageCS : ContentPage
	{
		public iOSEntryPageCS()
		{
			var entry = new Microsoft.Maui.Controls.Entry { Placeholder = "Enter text here to see the font size change", FontSize = 22 };
			entry.On<iOS>().EnableAdjustsFontSizeToFitWidth();
            entry.On<iOS>().SetCursorColor(Colors.LimeGreen);

			var button = new Button { Text = "Toggle AdjustsFontSizeToFitWidth" };
			button.Clicked += (sender, e) =>
			{
				entry.On<iOS>().SetAdjustsFontSizeToFitWidth(!entry.On<iOS>().AdjustsFontSizeToFitWidth());
			};

			Title = "Entry FontSize and CursorColor";
			Content = new StackLayout
			{
				Margin = new Thickness(20),
				Children = { entry, button }
			};
		}
	}
}
