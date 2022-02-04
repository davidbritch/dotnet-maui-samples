using SystemThemesDemo.Views;

namespace SystemThemesDemo;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new NavigationPage(new UserSummaryPage());
	}
}
