using Microsoft.Maui.Controls;

namespace MyMauiApp
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

			MyService service = new MyService();
			label.Text = service.GetPlatform();
		}
	}
}
