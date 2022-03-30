using Microsoft.Maui.Controls.PlatformConfiguration.WindowsSpecific;

namespace PlatformSpecifics
{
    public class WindowsImageSearchDirectoryPageCS : ContentPage
    {
        public WindowsImageSearchDirectoryPageCS()
        {
            Microsoft.Maui.Controls.Application.Current.On<Microsoft.Maui.Controls.PlatformConfiguration.Windows>().SetImageDirectory("Assets");

            Title = "Image Directory";
            Content = new StackLayout
            {
                Margin = new Thickness(10),
                Children = 
                {
                    new Image { Source = "Xamagon.png" },
                    new ImageButton { Source = "net_small_purple.png" },
                    new Button { ImageSource = "DotNetSource_small.png", BackgroundColor = Colors.Transparent }
                }
            };
        }
    }
}
