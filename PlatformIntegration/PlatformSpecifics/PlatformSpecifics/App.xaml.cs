namespace PlatformSpecifics;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new NavigationPage(new PlatformSpecificsPage());
	}

	public void SetMainPage(Page rootPage)
	{
		MainPage = rootPage;
	}
}
