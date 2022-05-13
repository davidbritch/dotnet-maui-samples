using System.Diagnostics;

namespace InputTransparentDemo;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    void OnClickFail(object sender, EventArgs e)
    {
        Debug.WriteLine("Failure; You shouldn't have been able to interact with that.");
        DisplayAlert("Failure", "You shouldn't have been able to interact with that.", "OK");
    }

    void OnClickSuccess(object sender, EventArgs e)
    {
        Debug.WriteLine("Success; That should have worked, and it did!");
        DisplayAlert("Success", "That should have worked, and it did!", "OK");
    }
}
