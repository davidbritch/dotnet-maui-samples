using System.Reflection;

namespace ImageDemos;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();

		resourceImage.Source = ImageSource.FromResource("ImageDemos.monkey.png");
		assemblyResourceImage.Source = ImageSource.FromResource("MyLibrary.monkey.png", typeof(MyLibrary.MyClass).GetTypeInfo().Assembly);
	}
}

