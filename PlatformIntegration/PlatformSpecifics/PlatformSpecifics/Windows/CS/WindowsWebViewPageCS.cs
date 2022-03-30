using Microsoft.Maui.Controls.PlatformConfiguration.WindowsSpecific;

namespace PlatformSpecifics
{
    public class WindowsWebViewPageCS : ContentPage
    {
		public WindowsWebViewPageCS()
		{
			var webView = new Microsoft.Maui.Controls.WebView
            {
                HeightRequest = 50,
				Source = new HtmlWebViewSource
				{
                    Html = @"<html><body><button onclick=""window.alert('Hello World from JavaScript');"">Click Me</button></body></html>"
                }
			};
			webView.On<Microsoft.Maui.Controls.PlatformConfiguration.Windows>().SetIsJavaScriptAlertEnabled(true);
            webView.On<Microsoft.Maui.Controls.PlatformConfiguration.Windows>().SetExecutionMode(WebViewExecutionMode.SeparateThread);

            var toggleButton = new Button { Text = "Toggle JavaScript alert" };
            toggleButton.Clicked += (sender, e) => webView.On<Microsoft.Maui.Controls.PlatformConfiguration.Windows>().SetIsJavaScriptAlertEnabled(!webView.On<Microsoft.Maui.Controls.PlatformConfiguration.Windows>().IsJavaScriptAlertEnabled());

            Title = "WebView JavaScript Alert";
            Content = new StackLayout
            {
                Margin = new Thickness(20),
                Children = { webView, toggleButton }
            };
		}
    }
}

