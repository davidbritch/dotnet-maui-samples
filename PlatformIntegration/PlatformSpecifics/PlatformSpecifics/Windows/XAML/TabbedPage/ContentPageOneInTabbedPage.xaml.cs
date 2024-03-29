﻿using System.Windows.Input;

namespace PlatformSpecifics
{
    public partial class ContentPageOneInTabbedPage : ContentPage
    {
        ICommand _returnToPlatformSpecificsPage;

        public ContentPageOneInTabbedPage(ICommand restore)
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
