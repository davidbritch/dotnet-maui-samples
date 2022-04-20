using Microsoft.Maui.Platform;

namespace CustomizeHandlersDemo;

public partial class CustomizeEntryPage : ContentPage
{
	public CustomizeEntryPage()
	{
		InitializeComponent();

		ModifyEntry();
	}

	void ModifyEntry()
    {
		Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping("MyCustomization", (handler, view) =>
		{
#if ANDROID
			handler.PlatformView.SetBackgroundColor(Colors.Transparent.ToPlatform());
#elif iOS
			handler.PlatformView.BorderStyle = UIKit.UITextBorderStyle.None;
#elif WINDOWS
			handler.PlatformView.FontWeight = Microsoft.UI.Text.FontWeights.Thin;
#endif
		});
    }

    void OnHandlerChanged(object sender, EventArgs e)
	{
#if ANDROID
		((sender as Entry).Handler.PlatformView as Android.Views.View).FocusChange += OnFocusChange;
#endif
	}

	void OnHandlerChanging(object sender, HandlerChangingEventArgs e)
	{
		if (e.OldHandler != null)
        {
#if ANDROID
			(e.OldHandler.PlatformView as Android.Views.View).FocusChange -= OnFocusChange;
#endif
		}
	}

#if ANDROID
	void OnFocusChange(object sender, EventArgs e)
    {
		var nativeView = sender as AndroidX.AppCompat.Widget.AppCompatEditText;

		if (nativeView.IsFocused)
        {
			nativeView.SetBackgroundColor(Colors.LightPink.ToPlatform());
        }
		else
        {
			nativeView.SetBackgroundColor(Colors.Transparent.ToPlatform());
        }
    }
#endif
}