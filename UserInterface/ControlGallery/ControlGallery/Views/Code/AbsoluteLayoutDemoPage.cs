using System;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;
using Microsoft.Maui.Layouts;

namespace ControlGallery.Views.Code
{
    class AbsoluteLayoutDemoPage : ContentPage
    {
        Label text1;
        Label text2;
        bool isCurrentPage;

        public AbsoluteLayoutDemoPage()
        {
            Label header = new Label
            {
                Text = "AbsoluteLayout",
                FontSize = 40,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            AbsoluteLayout absoluteLayout = new AbsoluteLayout
            {
                BackgroundColor = Colors.Blue.WithLuminosity(0.9f),
                VerticalOptions = LayoutOptions.FillAndExpand
            };

            // Create two Labels for animating.
            text1 = new Label 
            { 
                Text = "AbsoluteLayout",
                TextColor = Colors.Black
            };
            absoluteLayout.Add(text1);
            AbsoluteLayout.SetLayoutFlags(text1, AbsoluteLayoutFlags.PositionProportional);
            
            text2 = new Label 
            { 
                Text = "AbsoluteLayout",
                TextColor = Colors.Black
            };
            absoluteLayout.Add(text2);
            AbsoluteLayout.SetLayoutFlags(text2, AbsoluteLayoutFlags.PositionProportional);

            // Build the page.
            Title = "AbsoluteLayout Demo";
            Content = new StackLayout
            {
                Children = 
                {
                    header,
                    absoluteLayout
                }
            };
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            isCurrentPage = true;
            DateTime beginTime = DateTime.Now;

            Device.StartTimer(TimeSpan.FromSeconds(1.0  / 30), () =>
            {
                double seconds = (DateTime.Now - beginTime).TotalSeconds;
                double offset = 1 - Math.Abs((seconds % 2) - 1);

                AbsoluteLayout.SetLayoutBounds(text1,
                    new Rectangle(offset, offset, 
                        AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));

                AbsoluteLayout.SetLayoutBounds(text2,
                    new Rectangle(1 - offset, offset,
                        AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));

                return isCurrentPage;
            });
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            isCurrentPage = false;
        }
    }
}
