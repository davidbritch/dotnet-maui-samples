namespace ResourceDictionaryDemo;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	async void OnNavigateButtonClicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new ListDataPage());
	}
}

