namespace TapGesture
{
    public class TapInsideFrame : ContentPage
    {
        int tapCount;
        readonly Label label;

        public TapInsideFrame()
        {
            Frame frame = new Frame
            {
                BorderColor = Colors.Gray,
                BackgroundColor = Colors.Transparent,
                Padding = new Thickness(20, 100),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                Content = new Label
                {
                    Text = "Tap Inside Frame",
                    FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
                }
            };

            TapGestureRecognizer tapGestureRecognizer = new TapGestureRecognizer();
            //tapGestureRecognizer.NumberOfTapsRequired = 2; // double-tap
            tapGestureRecognizer.Tapped += OnTapGestureRecognizerTapped;
            frame.GestureRecognizers.Add(tapGestureRecognizer);

            label = new Label
            {
                Text = " ",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };

            Content = new StackLayout
            {
                Children =
                {
                    frame,
                    label
                }
            };
            Title = "Frame";
            IconImageSource = "csharp.png";
        }
        void OnTapGestureRecognizerTapped(object sender, EventArgs args)
        {
            tapCount++;
            label.Text = String.Format("{0} tap{1} so far!", tapCount, tapCount == 1 ? "" : "s");
        }
    }
}
