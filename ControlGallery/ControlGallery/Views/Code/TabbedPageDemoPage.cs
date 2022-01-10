using ControlGallery.Models;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;

namespace ControlGallery.Views.Code
{
    class TabbedPageDemoPage : TabbedPage
    {
        public TabbedPageDemoPage()
        {
            Title = "TabbedPage Demo";

            ItemsSource = new NamedColor[] 
            {
                new NamedColor("Red", Colors.Red),
                new NamedColor("Green", Colors.Green),
                new NamedColor("Blue", Colors.Blue),
                new NamedColor("Yellow", Colors.Yellow)
            };

            ItemTemplate = new DataTemplate(() => 
            { 
                return new NamedColorPage(false); 
            });
        }
    }
}
