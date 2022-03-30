using Microsoft.Maui.Controls.PlatformConfiguration;
using Microsoft.Maui.Controls.PlatformConfiguration.AndroidSpecific;
using WebView = Microsoft.Maui.Controls.WebView;

namespace PlatformSpecifics
{
    public class AndroidWebViewZoomPageCS : ContentPage
    {
        public AndroidWebViewZoomPageCS()
        {
            WebView webView = new WebView
            {
                Source = "https://www.xamarin.com"
            };

            webView.On<Microsoft.Maui.Controls.PlatformConfiguration.Android>()
                .SetEnableZoomControls(true)
                .SetDisplayZoomControls(true);

            Title = "WebView Zoom Controls";
            Content = webView;
        }
    }
}
