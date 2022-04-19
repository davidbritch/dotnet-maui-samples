namespace MultiWindowDemo;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	void OnOpenWindowClicked(object sender, EventArgs e)
    {
		Window window = new Window(new MyPage());
		Application.Current.OpenWindow(window);
	}

	void OnCloseWindowClicked(object sender, EventArgs e)
    {
		Application.Current.CloseWindow(GetParentWindow());
	}
}

