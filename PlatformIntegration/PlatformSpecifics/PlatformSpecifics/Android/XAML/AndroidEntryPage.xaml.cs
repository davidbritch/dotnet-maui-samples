using Microsoft.Maui.Controls.PlatformConfiguration;
using Microsoft.Maui.Controls.PlatformConfiguration.AndroidSpecific;

namespace PlatformSpecifics
{
    public partial class AndroidEntryPage : ContentPage
    {
        public AndroidEntryPage()
        {
            InitializeComponent();
        }

		void OnSelectedIndexChanged(object sender, EventArgs e)
		{
			ImeFlags flag = (ImeFlags)Enum.Parse(typeof(ImeFlags), _picker.SelectedItem.ToString());
			_entry.On<Microsoft.Maui.Controls.PlatformConfiguration.Android>().SetImeOptions(flag);
			_label.Text = $"ImeOptions: {_entry.On<Microsoft.Maui.Controls.PlatformConfiguration.Android>().ImeOptions()}";
		}
    }
}
