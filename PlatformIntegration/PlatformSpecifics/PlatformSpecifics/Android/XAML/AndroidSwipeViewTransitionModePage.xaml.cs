﻿using Microsoft.Maui.Controls.PlatformConfiguration;
using Microsoft.Maui.Controls.PlatformConfiguration.AndroidSpecific;

namespace PlatformSpecifics
{
    public partial class AndroidSwipeViewTransitionModePage : ContentPage
    {
        public AndroidSwipeViewTransitionModePage()
        {
            InitializeComponent();
        }

        void OnSwipeViewTransitionModeChanged(object sender, EventArgs e)
        {
            SwipeTransitionMode transitionMode = (SwipeTransitionMode)(sender as EnumPicker).SelectedItem;
            swipeView.On<Microsoft.Maui.Controls.PlatformConfiguration.Android>().SetSwipeTransitionMode(transitionMode);
        }

        async void OnDeleteSwipeItemInvoked(object sender, EventArgs e)
        {
            await DisplayAlert("SwipeView", "Delete invoked.", "OK");
        }
    }
}
