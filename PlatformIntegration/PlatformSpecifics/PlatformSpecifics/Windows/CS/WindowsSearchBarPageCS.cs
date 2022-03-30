using Microsoft.Maui.Controls.PlatformConfiguration.WindowsSpecific;

namespace PlatformSpecifics
{
    public class WindowsSearchBarPageCS : ContentPage
    {
        public WindowsSearchBarPageCS()
        {
			var searchBar = new Microsoft.Maui.Controls.SearchBar { Text = "Enter search term here" };
			searchBar.On<Microsoft.Maui.Controls.PlatformConfiguration.Windows>().SetIsSpellCheckEnabled(true);

			var toggleButton = new Button { Text = "Toggle spell check" };
			toggleButton.Clicked += (sender, e) => 
			{
				searchBar.On<Microsoft.Maui.Controls.PlatformConfiguration.Windows>().SetIsSpellCheckEnabled(!searchBar.On<Microsoft.Maui.Controls.PlatformConfiguration.Windows>().GetIsSpellCheckEnabled());
			};

			Title = "SearchBar Spell Check";
			Content = new StackLayout
            {
				Margin = new Thickness(20),
                Children = { searchBar, toggleButton }
            };
        }
    }
}
