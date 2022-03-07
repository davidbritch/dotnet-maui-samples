namespace WebViewDemos
{
    public partial class InAppBrowser : ContentPage
    {
        public InAppBrowser(string url)
        {
            InitializeComponent();
            webView.Source = url;
        }

        async void OnBackButtonClicked(object sender, EventArgs e)
        {
            if (webView.CanGoBack)
            {
                webView.GoBack();
            }
            else
            {
                await Navigation.PopAsync();
            }
        }

        void OnReloadButtonClicked(object sender, EventArgs e)
        {
            webView.Reload();
        }

        void OnForwardButtonClicked(object sender, EventArgs e)
        {
            if (webView.CanGoForward)
            {
                webView.GoForward();
            }
        }
    }
}

