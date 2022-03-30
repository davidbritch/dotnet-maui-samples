using Microsoft.Maui.Controls.PlatformConfiguration;
using Microsoft.Maui.Controls.PlatformConfiguration.iOSSpecific;

namespace PlatformSpecifics
{
    public class iOSTitleViewNavigationPageCS : Microsoft.Maui.Controls.NavigationPage
    {
        public iOSTitleViewNavigationPageCS(Microsoft.Maui.Controls.Page page)
        {
            On<iOS>().SetLargeTitleDisplay(LargeTitleDisplayMode.Always);
            On<iOS>().SetHideNavigationBarSeparator(true);
            PushAsync(page);
        }
    }
}
