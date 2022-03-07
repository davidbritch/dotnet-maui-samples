namespace WebViewDemos;

public partial class LaunchBrowserPage : ContentPage
{
	public LaunchBrowserPage()
	{
		InitializeComponent();
	}

	async void OnButtonClicked(object sender, EventArgs e)
	{
		await Launcher.OpenAsync("https://docs.microsoft.com/dotnet/maui");
	}
}