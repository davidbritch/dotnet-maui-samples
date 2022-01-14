namespace FontsDemo
{
    public class FontPageCode : ContentPage
    {
        public FontPageCode()
        {
            var label = new Label
            {
                Text = "Hello, Xamarin.Forms!",
                FontFamily = "Lobster"
            };

            label.FontSize = Device.RuntimePlatform == Device.iOS ? 24 :
                Device.RuntimePlatform == Device.Android ? Device.GetNamedSize(NamedSize.Medium, label) : Device.GetNamedSize(NamedSize.Large, label);

            var labelBold = new Label
            {
                Text = "Bold",
                FontSize = 14,
                FontAttributes = FontAttributes.Bold
            };
            var labelItalic = new Label
            {
                Text = "Italic",
                FontSize = 14,
                FontAttributes = FontAttributes.Italic
            };
            var labelBoldItalic = new Label
            {
                Text = "BoldItalic",
                FontSize = 14,
                FontAttributes = FontAttributes.Bold | FontAttributes.Italic
            };

            // Span formatting support
            var labelFormatted = new Label();
            var fs = new FormattedString();
            fs.Spans.Add(new Span { Text = "Red, ", TextColor = Colors.Red, FontSize = 20, FontAttributes = FontAttributes.Italic });
            fs.Spans.Add(new Span { Text = " blue, ", TextColor = Colors.Blue, FontSize = 32 });
            fs.Spans.Add(new Span { Text = " and green!", TextColor = Colors.Green, FontSize = 12 });
            labelFormatted.FormattedText = fs;

            Content = new StackLayout
            {
                Children =
                {
                    label, labelBold, labelItalic, labelBoldItalic, labelFormatted
                }
            };
        }
    }
}
