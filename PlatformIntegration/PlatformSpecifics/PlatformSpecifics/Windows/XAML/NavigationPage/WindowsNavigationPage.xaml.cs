﻿using System.Windows.Input;

namespace PlatformSpecifics
{
    public partial class WindowsNavigationPage : NavigationPage
    {
        public WindowsNavigationPage(ICommand restore)
        {
            InitializeComponent();
            PushAsync(new ContentPageOneInNavigationPage(restore));
        }

        async void OnToolbarItemClicked(object sender, EventArgs e)
        {
            await DisplayAlert(WindowsPlatformSpecificsHelpers.Title, WindowsPlatformSpecificsHelpers.Message, WindowsPlatformSpecificsHelpers.Dismiss);
        }
    }
}
