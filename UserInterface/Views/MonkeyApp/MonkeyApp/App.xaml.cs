namespace MonkeyApp;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new MonkeysPage();
	}
}
