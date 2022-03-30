using System.Windows.Input;
using Microsoft.Maui.Controls.PlatformConfiguration.WindowsSpecific;

namespace PlatformSpecifics
{
	public partial class WindowsTabbedPageIcons : Microsoft.Maui.Controls.TabbedPage
	{
        ICommand _returnToPlatformSpecificsPage;

        public WindowsTabbedPageIcons (ICommand restore)
		{
			InitializeComponent ();
            _returnToPlatformSpecificsPage = restore;
		}

        void OnToggleButtonClicked(object sender, EventArgs e)
        {
            On<Microsoft.Maui.Controls.PlatformConfiguration.Windows>().SetHeaderIconsEnabled(!On<Microsoft.Maui.Controls.PlatformConfiguration.Windows>().GetHeaderIconsEnabled());
        }

        void OnReturnButtonClicked(object sender, EventArgs e)
        {
            _returnToPlatformSpecificsPage.Execute(null);
        }
    }
}