﻿namespace ButtonDemos
{
    public class CodeButtonClickPage : ContentPage
    {
        public CodeButtonClickPage ()
        {
            Title = "Code Button Click";

            Label label = new Label
            {
                Text = "Click the Button above",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center
            };

            Button button = new Button
            {
                Text = "Click to Rotate Text!",
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center
            };
            button.Clicked += async (sender, args) => await label.RelRotateTo(360, 1000);

            Content = new StackLayout
            {
                Children =
                {
                    button,
                    label
                }
            };
        }
    }
}