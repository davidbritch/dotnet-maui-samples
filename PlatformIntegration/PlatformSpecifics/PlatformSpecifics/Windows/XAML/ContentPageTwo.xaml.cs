﻿using System.Windows.Input;

namespace PlatformSpecifics
{
    public partial class ContentPageTwo : ContentPage
    {
        ICommand _returnToPlatformSpecificsPage;

        public ContentPageTwo(ICommand restore)
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
