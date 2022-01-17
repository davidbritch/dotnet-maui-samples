namespace DataBindingDemos;

public partial class App : Application
{
    public SampleSettingsViewModel Settings { get; private set; }

    public App()
	{
		InitializeComponent();

        Settings = new SampleSettingsViewModel(Current.Properties);
        MainPage = new NavigationPage(new MainPage());
	}

    protected override void OnSleep()
    {
        // TODO: API obsolete
        Settings.SaveState(Current.Properties);
    }
}
