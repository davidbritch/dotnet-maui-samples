﻿using System.Windows.Input;

namespace SearchBarDemos;

public partial class MainPage : ContentPage
{
    public ICommand NavigateCommand { get; set; }

    public MainPage()
    {
        InitializeComponent();

        NavigateCommand = new Command<Type>(async (Type pageType) =>
        {
            Page page = (Page)Activator.CreateInstance(pageType);
            await Navigation.PushAsync(page);
        });

        BindingContext = this;
    }
}

