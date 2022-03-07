namespace WebViewDemos
{
	public partial class LinkToInApp : ContentPage
	{
		public LinkToInApp ()
		{
			InitializeComponent ();
		}

		async void OnButtonClicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync (new InAppBrowser ("https://docs.microsoft.com/dotnet/maui"));
		}
	}
}

