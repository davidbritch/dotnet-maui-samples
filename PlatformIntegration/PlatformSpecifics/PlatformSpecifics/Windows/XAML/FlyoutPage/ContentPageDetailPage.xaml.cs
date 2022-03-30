using System.Windows.Input;

namespace PlatformSpecifics
{
    public partial class ContentPageDetailPage : ContentPage
    {
        ICommand _returnToPlatformSpecificsPage;

        public ContentPageDetailPage(ICommand restore)
        {
            InitializeComponent();
            _returnToPlatformSpecificsPage = restore;
        }

        void OnReturnButtonClicked(object sender, EventArgs e)
        {
            _returnToPlatformSpecificsPage.Execute(null);
        }
    }
}
