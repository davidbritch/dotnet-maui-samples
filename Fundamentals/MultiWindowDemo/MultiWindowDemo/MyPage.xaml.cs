namespace MultiWindowDemo;

public partial class MyPage : ContentPage
{
	public MyPage()
	{
		InitializeComponent();
	}

	void OnCloseWindowClicked(object sender, EventArgs e)
    {
		Application.Current.CloseWindow(GetParentWindow());
    }
}