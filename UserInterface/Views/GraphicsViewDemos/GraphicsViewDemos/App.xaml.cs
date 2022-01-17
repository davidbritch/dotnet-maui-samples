using Microsoft.Maui.Controls;
using Application = Microsoft.Maui.Controls.Application;
using GraphicsViewDemos.Views;

namespace GraphicsViewDemos
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new NavigationPage(new MainPage());
		}
	}
}
