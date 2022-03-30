using Microsoft.Maui.Controls.PlatformConfiguration;
using Microsoft.Maui.Controls.PlatformConfiguration.iOSSpecific;

namespace PlatformSpecifics
{
    public partial class iOSSliderUpdateOnTapPage : ContentPage
    {
        public iOSSliderUpdateOnTapPage()
        {
            InitializeComponent();
        }

        void OnButtonClicked(object sender, EventArgs e)
        {
            _slider.On<iOS>().SetUpdateOnTap(!_slider.On<iOS>().GetUpdateOnTap());
        }
    }
}
