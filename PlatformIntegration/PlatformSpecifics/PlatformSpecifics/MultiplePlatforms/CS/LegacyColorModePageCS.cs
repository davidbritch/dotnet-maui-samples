using Microsoft.Maui.Controls.PlatformConfiguration;
using Microsoft.Maui.Controls.PlatformConfiguration.iOSSpecific;
using Microsoft.Maui.Controls.PlatformConfiguration.AndroidSpecific;

namespace PlatformSpecifics
{
    public class LegacyColorModePageCS : ContentPage
    {
		Microsoft.Maui.Controls.Button _defaultColorModeButton, _legacyColorModeDisabledButton;

        public LegacyColorModePageCS()
        {
			_defaultColorModeButton = new Microsoft.Maui.Controls.Button { Text = "Button", TextColor = Colors.Blue, BackgroundColor = Colors.Bisque };
			var defaultIsEnabledButton = new Microsoft.Maui.Controls.Button { Text = "Toggle IsEnabled" };
			defaultIsEnabledButton.Clicked += (sender, e) => 
			{
				var button = sender as Microsoft.Maui.Controls.Button;
                ToggleIsEnabled(_defaultColorModeButton, button);
			};

			_legacyColorModeDisabledButton = new Microsoft.Maui.Controls.Button { Text = "Button", TextColor = Colors.Blue, BackgroundColor = Colors.Bisque };
			_legacyColorModeDisabledButton.On<iOS>().SetIsLegacyColorModeEnabled(false);
			_legacyColorModeDisabledButton.On<Microsoft.Maui.Controls.PlatformConfiguration.Android>().SetIsLegacyColorModeEnabled(false);

			var legacyColorModeDisabledIsEnabledButton = new Microsoft.Maui.Controls.Button { Text = "Toggle IsEnabled" };
			legacyColorModeDisabledIsEnabledButton.Clicked += (sender, e) => 
			{
				var button = sender as Microsoft.Maui.Controls.Button;
				ToggleIsEnabled(_legacyColorModeDisabledButton, button);
			};

			Title = "Legacy Color Mode";
			Content = new StackLayout
			{
				Margin = new Thickness(20),
				Children = 
				{
					new Microsoft.Maui.Controls.Label { Text = "The Button below uses the legacy color mode. When IsEnabled is false, it uses the default native colors for the control." },
					_defaultColorModeButton,
					defaultIsEnabledButton,
					new Microsoft.Maui.Controls.Label { Text= "The Button below has the legacy color mode disabled. It will use whatever colors are manually set." },
					_legacyColorModeDisabledButton,
					legacyColorModeDisabledIsEnabledButton
                }
            };
        }

        void ToggleIsEnabled(Microsoft.Maui.Controls.Button button, Microsoft.Maui.Controls.Button toggleButton)
        {
        	button.IsEnabled = !button.IsEnabled;
        	if (toggleButton != null)
        	{
        		toggleButton.Text = $"Toggle IsEnabled (Currently: {button.IsEnabled})";
        	}
        }   
	}
}
              