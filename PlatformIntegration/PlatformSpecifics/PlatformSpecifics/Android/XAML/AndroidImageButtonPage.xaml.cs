using Microsoft.Maui.Controls.PlatformConfiguration;
using Microsoft.Maui.Controls.PlatformConfiguration.AndroidSpecific;

namespace PlatformSpecifics
{
    public partial class AndroidImageButtonPage : ContentPage
    {
        public AndroidImageButtonPage()
        {
            InitializeComponent();
        }

        void OnImageButtonClicked(object sender, EventArgs e)
        {
            var imageButton = sender as Microsoft.Maui.Controls.ImageButton;
            imageButton.On<Microsoft.Maui.Controls.PlatformConfiguration.Android>().SetIsShadowEnabled(!imageButton.On<Microsoft.Maui.Controls.PlatformConfiguration.Android>().GetIsShadowEnabled());
        }
    }
}

