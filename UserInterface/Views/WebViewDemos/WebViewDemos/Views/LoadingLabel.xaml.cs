namespace WebViewDemos
{
    public partial class LoadingLabel : ContentPage
    {
        public LoadingLabel()
        {
            InitializeComponent();
        }

        void OnWebviewNavigating(object sender, WebNavigatingEventArgs e)
        {
            label.IsVisible = true;
        }

        void OnWebviewNavigated(object sender, WebNavigatedEventArgs e)
        {
            label.IsVisible = false;
        }
    }
}

