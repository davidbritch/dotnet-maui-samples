using Microsoft.Maui.Platform;

namespace CustomizeHandlersDemo;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new CustomizePartialEntryPage();
		//MainPage = new MainPage();
		//CustomizeBackgroundColor();
		//RemoveEntryUnderline();
		//CustomizeEntryBackgroundColor();
		AllowMultiLineTruncationOnAndroid();
	}

	void CustomizeBackgroundColor()
    {
#if ANDROID
		Microsoft.Maui.Handlers.ViewHandler.ViewMapper.AppendToMapping(nameof(IView.Background), (handler, view) =>
		{
			(handler.PlatformView as Android.Views.View).SetBackgroundColor(Colors.Cyan.ToPlatform());
		});
#endif
	}

	void RemoveEntryUnderline()
    {
#if ANDROID
		Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping("NoUnderline", (handler, view) =>
		{
			handler.PlatformView.BackgroundTintList = Android.Content.Res.ColorStateList.ValueOf(Colors.Transparent.ToPlatform());
		});
#endif
	}

	void CustomizeEntryBackgroundColor()
    {
		Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping(nameof(IView.Background), (handler, view) =>
		{
			if (view is MyEntry)
            {
#if ANDROID
				handler.PlatformView.SetBackgroundColor(Colors.Red.ToPlatform());
#elif IOS
				handler.PlatformView.BackgroundColor = Colors.Red.ToPlatform();
				handler.PlatformView.BorderStyle = UIKit.UITextBorderStyle.Line;
#elif WINDOWS
				handler.PlatformView.Background = Colors.Red.ToPlatform();
#endif
			}
		});
	}

	void AllowMultiLineTruncationOnAndroid()
    {
#if ANDROID
		void UpdateMaxLines(Microsoft.Maui.Handlers.LabelHandler handler, ILabel label)
		{
			var textView = handler.PlatformView;
			if (textView.Ellipsize == Android.Text.TextUtils.TruncateAt.End)
            {
				textView.SetMaxLines(label.MaxLines);
            }
		}

		Label.ControlsLabelMapper.AppendToMapping(nameof(Label.LineBreakMode), UpdateMaxLines);
		Label.ControlsLabelMapper.AppendToMapping(nameof(Label.MaxLines), UpdateMaxLines);
#endif
	}
}
