﻿using System.Windows.Input;

namespace SwipeGesture;

public partial class MainPage : ContentPage
{
    public ICommand NavigateCommand { get; private set; }

    public MainPage()
    {
        InitializeComponent();

        NavigateCommand = new Command<Type>(async (pageType) =>
        {
            Page page = (Page)Activator.CreateInstance(pageType);
            await Navigation.PushAsync(page);
        });
        BindingContext = this;
    }
}

