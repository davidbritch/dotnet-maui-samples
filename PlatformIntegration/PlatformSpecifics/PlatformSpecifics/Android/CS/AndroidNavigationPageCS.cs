using Microsoft.Maui.Controls.PlatformConfiguration;
using Microsoft.Maui.Controls.PlatformConfiguration.AndroidSpecific.AppCompat;

namespace PlatformSpecifics
{
    public class AndroidNavigationPageCS : Microsoft.Maui.Controls.NavigationPage
    {
        public AndroidNavigationPageCS(Page page)
        {
            On<Microsoft.Maui.Controls.PlatformConfiguration.Android>().SetBarHeight(450);
            PushAsync(page);
        }
    }
}
