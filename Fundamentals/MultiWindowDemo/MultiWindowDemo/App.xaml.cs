namespace MultiWindowDemo;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}

    protected override Window CreateWindow(IActivationState activationState)
    {
		Window window = base.CreateWindow(activationState);

		// Manipulate Window object

		return window;
    }
}
