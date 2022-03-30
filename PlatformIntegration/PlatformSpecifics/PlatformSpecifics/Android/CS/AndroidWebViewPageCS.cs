using Microsoft.Maui.Controls.PlatformConfiguration;
using Microsoft.Maui.Controls.PlatformConfiguration.AndroidSpecific;

namespace PlatformSpecifics
{
    public class AndroidWebViewPageCS : ContentPage
    {
        public AndroidWebViewPageCS()
        {
			var webView = new Microsoft.Maui.Controls.WebView { Source = "https://htmlpreview.github.io/?https://github.com/xamarin/xamarin-forms-samples/blob/master/UserInterface/PlatformSpecifics/HTML/mixed_content.html" };
			webView.On<Microsoft.Maui.Controls.PlatformConfiguration.Android>().SetMixedContentMode(MixedContentHandling.AlwaysAllow);
			Content = webView;
        }
    }
}
