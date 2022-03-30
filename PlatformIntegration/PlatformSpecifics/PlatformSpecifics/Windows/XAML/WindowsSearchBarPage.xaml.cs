using Microsoft.Maui.Controls.PlatformConfiguration.WindowsSpecific;

namespace PlatformSpecifics
{
    public partial class WindowsSearchBarPage : ContentPage
    {
        public WindowsSearchBarPage()
        {
            InitializeComponent();
        }

        void OnToggleButtonClicked(object sender, EventArgs e)
		{
			_searchBar.On<Microsoft.Maui.Controls.PlatformConfiguration.Windows>().SetIsSpellCheckEnabled(!_searchBar.On<Microsoft.Maui.Controls.PlatformConfiguration.Windows>().GetIsSpellCheckEnabled());
		}
    }
}
