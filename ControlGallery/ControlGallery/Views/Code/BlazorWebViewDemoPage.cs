using Microsoft.Maui.Controls;
using Microsoft.AspNetCore.Components.WebView.Maui;

namespace ControlGallery.Views.Code
{
    public class BlazorWebViewDemoPage : ContentPage
    {
        public BlazorWebViewDemoPage()
        {
            BlazorWebView blazorWebView = new BlazorWebView
            {
                HostPage = "wwwroot/index.html"
            };
            blazorWebView.RootComponents.Add(new RootComponent
            {
                Selector = "#app",
                ComponentType = typeof(Main)
            });

            // Build the page.
            Title = "BlazorWebView Demo";
            Content = blazorWebView;
        }
    }
}
