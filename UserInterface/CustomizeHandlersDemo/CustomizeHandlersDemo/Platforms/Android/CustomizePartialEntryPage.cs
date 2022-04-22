using Microsoft.Maui.Platform;

namespace CustomizeHandlersDemo
{
    public partial class CustomizePartialEntryPage : ContentPage
    {
        partial void ChangedHandler(object sender, EventArgs e)
        {
            ((sender as Entry).Handler.PlatformView as Android.Views.View).FocusChange += OnFocusChange;
        }

        partial void ChangingHandler(object sender, HandlerChangingEventArgs e)
        {
            if (e.OldHandler != null)
            {
                (e.OldHandler.PlatformView as Android.Views.View).FocusChange -= OnFocusChange;
            }
        }

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
    }
}
