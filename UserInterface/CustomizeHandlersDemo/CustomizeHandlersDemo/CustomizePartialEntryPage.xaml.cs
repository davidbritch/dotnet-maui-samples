namespace CustomizeHandlersDemo;

public partial class CustomizePartialEntryPage : ContentPage
{
	public CustomizePartialEntryPage()
	{
		InitializeComponent();
	}

	partial void ChangedHandler(object sender, EventArgs e);
	partial void ChangingHandler(object sender, HandlerChangingEventArgs e);

	void OnHandlerChanged(object sender, EventArgs e) => ChangedHandler(sender, e);

	void OnHandlerChanging(object sender, HandlerChangingEventArgs e) => ChangingHandler(sender, e);
}