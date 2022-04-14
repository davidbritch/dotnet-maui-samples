namespace FontsDemo
{
    public class FontPageCode : ContentPage
    {
        public FontPageCode()
        {
            var label = new Label
            {
                Text = "Hello from C#",
                FontFamily = "Lobster"
            };

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
            var platformSizedLabel = new Label
            {
                Text = "Label sized differently per platform"
            };
            platformSizedLabel.FontSize = DeviceInfo.Platform == DevicePlatform.Android ? 20 :
                DeviceInfo.Platform == DevicePlatform.WinUI ? 24 : 22;
            
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
                    label, labelBold, labelItalic, labelBoldItalic, labelFormatted, platformSizedLabel
                }
            };
        }
    }
}
