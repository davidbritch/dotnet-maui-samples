using System;
using Microsoft.Maui.Controls;

namespace ControlGallery.Views.Code
{
    class WebViewDemoPage : ContentPage
    {
        public WebViewDemoPage()
        {
            Label header = new Label
            {
                Text = "WebView",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            WebView webView = new WebView
            {
                Source = new UrlWebViewSource
                {
                    Url = "https://www.xamarin.com/"
                },
                VerticalOptions = LayoutOptions.FillAndExpand
            };

            // Build the page.
            Title = "WebView Demo";
            Content = new StackLayout
            {
                Children = 
                {
                    header,
                    webView
                }
            };
        }
    }
}
