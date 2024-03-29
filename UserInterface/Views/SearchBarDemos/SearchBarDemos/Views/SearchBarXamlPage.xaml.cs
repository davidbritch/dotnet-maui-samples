﻿using SearchBarDemos.Services;

namespace SearchBarDemos
{
    public partial class SearchBarXamlPage : ContentPage
    {
        public SearchBarXamlPage()
        {
            InitializeComponent();
            searchResults.ItemsSource = DataService.Fruits;
        }

        void OnSearchButtonPressed(object sender, EventArgs e)
        {
            searchResults.ItemsSource = DataService.GetSearchResults(searchBar.Text);
        }
    }
}