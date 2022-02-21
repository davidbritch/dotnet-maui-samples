namespace PanGesture;

public partial class App : Application
{
	public static double ScreenWidth;
	public static double ScreenHeight;

	public App()
	{
		InitializeComponent();

		DisplayInfo displayInfo = DeviceDisplay.MainDisplayInfo;
		ScreenWidth = displayInfo.Width;
		ScreenHeight = displayInfo.Height;

		MainPage = new MainPage();
	}
}
