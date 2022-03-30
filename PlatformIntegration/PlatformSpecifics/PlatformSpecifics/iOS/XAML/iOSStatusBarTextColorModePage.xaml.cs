using System.Windows.Input;
using Microsoft.Maui.Controls.PlatformConfiguration;
using Microsoft.Maui.Controls.PlatformConfiguration.iOSSpecific;

namespace PlatformSpecifics
{
    public partial class iOSStatusBarTextColorModePage : Microsoft.Maui.Controls.FlyoutPage
    {
        ICommand _returnToPlatformSpecificsPage;

        public iOSStatusBarTextColorModePage(ICommand restore)
        {
            InitializeComponent();
            _returnToPlatformSpecificsPage = restore;

            IsPresentedChanged += (sender, e) =>
            {
                var mdp = sender as Microsoft.Maui.Controls.FlyoutPage;
                if (mdp.IsPresented)
                    ((Microsoft.Maui.Controls.NavigationPage)mdp.Detail).On<iOS>().SetStatusBarTextColorMode(StatusBarTextColorMode.DoNotAdjust);
                else
                    ((Microsoft.Maui.Controls.NavigationPage)mdp.Detail).On<iOS>().SetStatusBarTextColorMode(StatusBarTextColorMode.MatchNavigationBarTextLuminosity);
            };
        }

        void OnReturnButtonClicked(object sender, EventArgs e)
        {
            _returnToPlatformSpecificsPage.Execute(null);
        }
    }
}
