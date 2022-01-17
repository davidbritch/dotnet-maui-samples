using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;
using ControlGallery.Models;

namespace ControlGallery.Views.Code
{
    class CarouselPageDemoPage : CarouselPage
    {
        public CarouselPageDemoPage()
        {
            Title = "CarouselPage Demo";

            ItemsSource = new NamedColor[] 
            {
                new NamedColor("Red", Colors.Red),
                new NamedColor("Yellow", Colors.Yellow),
                new NamedColor("Green", Colors.Green),
                new NamedColor("Aqua", Colors.Aqua),
                new NamedColor("Blue", Colors.Blue),
                new NamedColor("Purple", Colors.Purple)
            };

            ItemTemplate = new DataTemplate(() =>
            {
                return new NamedColorPage(true);
            });
        }
    }
}
