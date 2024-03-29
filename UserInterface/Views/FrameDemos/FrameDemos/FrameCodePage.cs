﻿namespace FrameDemos
{
    public class FrameCodePage : ContentPage
    {
        public FrameCodePage()
        {
            Padding = 10;
            Title = "Frame Code Demo";

            Frame defaultFrame = new Frame
            {
                Content = new Label { Text = "Default" }
            };

            Frame noShadowFrame = new Frame
            {
                BackgroundColor = Colors.LightGray,
                BorderColor = Colors.Orange,
                Content = new Label { Text = "HasShadow False (platform-dependent)" },
                CornerRadius = 10,
                HasShadow = false
            };

            Frame forceShadowFrame = new Frame
            {
                BackgroundColor = Colors.LightGray,
                BorderColor = Colors.Orange,
                Content = new Label { Text = "HasShadow True (platform-dependent)" },
                CornerRadius = 10,
                HasShadow = true
            };

            Frame circleImageFrame = new Frame
            {
                Margin = 10,
                BorderColor = Colors.Black,
                CornerRadius = 50,
                HeightRequest = 60,
                WidthRequest = 60,
                IsClippedToBounds = true,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                Content = new Image
                {
                    Source = ImageSource.FromFile("outdoors.jpg"),
                    Aspect = Aspect.AspectFill,
                    Margin = -20,
                    HeightRequest = 100,
                    WidthRequest = 100
                }
            };

            Frame cardFrame = new Frame
            {
                BorderColor = Colors.Gray,
                CornerRadius = 5,
                Padding = 8,
                Content = new StackLayout
                {
                    Spacing = 6,
                    Children =
                    {
                        new Label
                        {
                            Text = "Card Example",
                            FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                            FontAttributes = FontAttributes.Bold
                        },
                        new BoxView
                        {
                            Color = Colors.Gray,
                            HeightRequest = 2,
                            HorizontalOptions = LayoutOptions.Fill
                        },
                        new Label
                        {
                            Text = "Frames can wrap more complex layouts to create more complex UI components, such as this card!"
                        }
                    }
                }
            };

            Content = new ScrollView
            {
                Content = new StackLayout
                {
                    Spacing = 6,
                    Children =
                    {
                        defaultFrame,
                        noShadowFrame,
                        forceShadowFrame,
                        circleImageFrame,
                        cardFrame
                    }
                }
            };
        }
    }
}