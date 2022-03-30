using Microsoft.Maui.Controls.PlatformConfiguration;
using Microsoft.Maui.Controls.PlatformConfiguration.iOSSpecific;

namespace PlatformSpecifics
{
    public partial class iOSShadowEffectPage : ContentPage
    {
        public iOSShadowEffectPage()
        {
            InitializeComponent();
        }

        void OnButtonClicked(object sender, EventArgs e)
        {
            _boxView.On<iOS>().SetIsShadowEnabled(!_boxView.On<iOS>().GetIsShadowEnabled());
        }
    }
}
