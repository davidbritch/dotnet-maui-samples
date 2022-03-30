using Microsoft.Maui.Controls.PlatformConfiguration;
using Microsoft.Maui.Controls.PlatformConfiguration.iOSSpecific;

namespace PlatformSpecifics
{
    public class iOSSearchBarPageCS : ContentPage
    {
        public iOSSearchBarPageCS()
        {
            Microsoft.Maui.Controls.SearchBar searchBar = new Microsoft.Maui.Controls.SearchBar { Placeholder = "Enter search term" };
            searchBar.On<iOS>().SetSearchBarStyle(UISearchBarStyle.Minimal);

            Button styleButton = new Button { Text = "Toggle SearchBar Style" };
            styleButton.Clicked += (s, e) =>
            {
                switch (searchBar.On<iOS>().GetSearchBarStyle())
                {
                    case UISearchBarStyle.Default:
                        searchBar.On<iOS>().SetSearchBarStyle(UISearchBarStyle.Minimal);
                        break;
                    case UISearchBarStyle.Minimal:
                        searchBar.On<iOS>().SetSearchBarStyle(UISearchBarStyle.Prominent);
                        break;
                    case UISearchBarStyle.Prominent:
                        searchBar.On<iOS>().SetSearchBarStyle(UISearchBarStyle.Default);
                        break;
                }
            };

            Button backgroundButton = new Button { Text = "Toggle Background" };
            backgroundButton.Clicked += (s, e) => searchBar.BackgroundColor = (searchBar.BackgroundColor == Colors.Teal) ? Colors.Black : Colors.Teal;

            Title = "SearchBar Style";
            Content = new StackLayout
            {
                Children =
                {
                    searchBar,
                    styleButton,
                    backgroundButton
                }
            };
        }
    }
}
