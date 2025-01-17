namespace WebViewDemos;

public partial class DisplayLocalWebPage : ContentPage
{
	public DisplayLocalWebPage()
	{
		InitializeComponent();

#if ANDROID
		Microsoft.Maui.Handlers.WebViewHandler.Mapper.AppendToMapping("SupportMultipleWindows", (handler, view) =>
		{
			handler.PlatformView.Settings.SetSupportMultipleWindows(false);
		});
#endif
    }
}

