using Microsoft.Maui.Controls.PlatformConfiguration;
using Microsoft.Maui.Controls.PlatformConfiguration.WindowsSpecific;

namespace PlatformSpecifics
{   
    public class WindowsLegacyColorModePageCS : ContentPage
    {
		Editor _defaultColorModeEditor, _legacyColorModeDisabledEditor;

        public WindowsLegacyColorModePageCS()
        {
			_defaultColorModeEditor = new Editor { Text = "Enter text here", TextColor = Colors.Blue, BackgroundColor = Colors.Bisque };
            var defaultIsEnabledButton = new Microsoft.Maui.Controls.Button { Text = "Toggle IsEnabled" };
            defaultIsEnabledButton.Clicked += (sender, e) =>
            {
				var button = sender as Button;
                ToggleIsEnabled(_defaultColorModeEditor, button);
            };

            _legacyColorModeDisabledEditor = new Editor { Text = "Enter text here", TextColor = Colors.Blue, BackgroundColor = Colors.Bisque };
            _legacyColorModeDisabledEditor.On<Microsoft.Maui.Controls.PlatformConfiguration.Windows>().SetIsLegacyColorModeEnabled(false);

            var legacyColorModeDisabledIsEnabledButton = new Microsoft.Maui.Controls.Button { Text = "Toggle IsEnabled" };
            legacyColorModeDisabledIsEnabledButton.Clicked += (sender, e) =>
            {
				var button = sender as Button;
                ToggleIsEnabled(_legacyColorModeDisabledEditor, button);
            };

            Title = "Legacy Color Mode";
            Content = new StackLayout
            {
                Margin = new Thickness(20),
                Children =
                {
                    new Microsoft.Maui.Controls.Label { Text = "The Editor below uses the legacy color mode. When IsEnabled is false, it uses the default native colors for the control." },
                    _defaultColorModeEditor,
                    defaultIsEnabledButton,
                    new Microsoft.Maui.Controls.Label { Text= "The Editor below has the legacy color mode disabled. It will use whatever colors are manually set." },
                    _legacyColorModeDisabledEditor,
                    legacyColorModeDisabledIsEnabledButton
                }
            };
        }

		void ToggleIsEnabled(Editor editor, Button toggleButton)
        {
            editor.IsEnabled = !editor.IsEnabled;
            if (toggleButton != null)
            {
                toggleButton.Text = $"Toggle IsEnabled (Currently: {editor.IsEnabled})";
            }
        }
    }
}
