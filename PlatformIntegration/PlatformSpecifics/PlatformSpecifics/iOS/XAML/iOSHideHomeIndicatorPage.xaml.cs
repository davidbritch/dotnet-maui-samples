using Microsoft.Maui.Controls.PlatformConfiguration;
using Microsoft.Maui.Controls.PlatformConfiguration.iOSSpecific;

namespace PlatformSpecifics
{
    public partial class iOSHideHomeIndicatorPage : ContentPage
    {
        public iOSHideHomeIndicatorPage()
        {
            InitializeComponent();
        }

        async void OnNavigationPageClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new iOSHideHomeIndicatorNavigationPage());
            On<iOS>().SetPrefersHomeIndicatorAutoHidden(!On<iOS>().PrefersHomeIndicatorAutoHidden());
        }

        async void OnTabbedPageClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new iOSHideHomeIndicatorContentPage());
            On<iOS>().SetPrefersHomeIndicatorAutoHidden(!On<iOS>().PrefersHomeIndicatorAutoHidden());
        }

        async void OnFlyoutPageClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new iOSHideHomeIndicatorFlyoutPage());
            On<iOS>().SetPrefersHomeIndicatorAutoHidden(!On<iOS>().PrefersHomeIndicatorAutoHidden());
        }

        async void OnShellClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new iOSHideHomeIndicatorShell());
            On<iOS>().SetPrefersHomeIndicatorAutoHidden(!On<iOS>().PrefersHomeIndicatorAutoHidden());
        }
    }

    public class iOSHideHomeIndicatorNavigationPage : ContentPage
    {
        public iOSHideHomeIndicatorNavigationPage()
        {
            Content = new StackLayout()
            {
                Margin = new Microsoft.Maui.Thickness(20),
                Children = {
                    new Button()
                    {
                        Text = "Toggle Home Indicator",
                        Command = new Command(() => On<iOS>().SetPrefersHomeIndicatorAutoHidden(!On<iOS>().PrefersHomeIndicatorAutoHidden()))
                    },
                    new Button()
                    {
                        Text = "Navigate back",
                        Command = new Command(() => Navigation.PopAsync())
                    }
                }
            };
        }
    }

    public class iOSHideHomeIndicatorFlyoutPage : Microsoft.Maui.Controls.FlyoutPage
    {
        public iOSHideHomeIndicatorFlyoutPage()
        {
            Flyout = new ContentPage()
            {
                Title = "Detail",
                Content = new StackLayout()
                {
                    Children = {
                        new Button()
                        {
                            Text = "Open page 1",
                            Command = new Command(() => Detail = OpenPage("Page 1"))
                        },
                        new Button()
                        {
                            Text = "Open page 2",
                            Command = new Command(() => Detail = OpenPage("Page 2"))
                        }
                    }
                }
            };

            Detail = OpenPage("Page 1");
        }

        public ContentPage OpenPage(string title)
        {
            return new ContentPage()
            {
                Title = title,
                Content = new StackLayout()
                {
                    Margin = new Microsoft.Maui.Thickness(20),
                    Children = {
                        new Button
                        {
                            Text = "Toggle Home Indicator",
                            Command = new Command(() => On<iOS>().SetPrefersHomeIndicatorAutoHidden(!On<iOS>().PrefersHomeIndicatorAutoHidden()))
                        },
                        new Button()
                        {
                            Text = "Click to open the flyout",
                            Command = new Command(() => IsPresented = true)
                        },
                        new Button
                        {
                            VerticalOptions = LayoutOptions.End,
                            Text = "Back",
                            Command = new Command(() => Navigation.PopAsync())
                        }
                    }
                }
            };
        }
    }

    public class iOSHideHomeIndicatorContentPage : Microsoft.Maui.Controls.TabbedPage
    {
        public iOSHideHomeIndicatorContentPage()
        {

            Children.Add
            (
                new ContentPage()
                {
                    Title = "Tab 1",
                    Content = new StackLayout()
                    {
                        Margin = new Microsoft.Maui.Thickness(20),
                        Children =
                            {
                                new Button()
                                {
                                    Text = "Toggle Home Indicator",
                                    Command = new Command(() => On<iOS>().SetPrefersHomeIndicatorAutoHidden(!On<iOS>().PrefersHomeIndicatorAutoHidden()))
                                },
                                new Button()
                                {
                                    Text = "Navigate back",
                                    Command = new Command(() => Navigation.PopAsync())
                                }
                            }
                    }
                }
            );

            Children.Add
            (
                new ContentPage()
                {
                    Title = "Tab 2",
                    Content = new StackLayout()
                    {
                        Margin = new Microsoft.Maui.Thickness(20),
                        Children =
                        {
                            new Button()
                            {
                                Text = "Toggle Home Indicator",
                                Command = new Command(() => On<iOS>().SetPrefersHomeIndicatorAutoHidden(!On<iOS>().PrefersHomeIndicatorAutoHidden()))
                            },
                            new Button()
                            {
                                Text = "Navigate back",
                                Command = new Command(() => Navigation.PopAsync())
                            }
                        }
                    }
                }
            );

        }
    }

    public class iOSHideHomeIndicatorShell : Shell
    {
        public iOSHideHomeIndicatorShell()
        {
            TabBar tabBar = new TabBar();

            var toggleHomeIndicatorButton1 = new Button()
            {
                Text = "Toggle Home Indicator",
                Command = new Command(() => On<iOS>().SetPrefersHomeIndicatorAutoHidden(!On<iOS>().PrefersHomeIndicatorAutoHidden()))
            };

            var contentPage1 = new ContentPage
            {
                Title = "Shell Tab 1",
                Content = new StackLayout()
                {
                    Margin = new Microsoft.Maui.Thickness(20),
                    Children =
                    {
                        toggleHomeIndicatorButton1,
                        new Button()
                        {
                            Text = "Navigate back",
                            Command = new Command(() => Navigation.PopAsync())
                        }
                    }
                }
            };

            toggleHomeIndicatorButton1.Command = new Command(() => contentPage1.On<iOS>().SetPrefersHomeIndicatorAutoHidden(!On<iOS>().PrefersHomeIndicatorAutoHidden()));

            tabBar.Items.Add
            (
                new Tab
                {
                    Title = "Shell Tab 1",
                    Items = {
                        new ShellContent
                        {
                            Content = contentPage1,
                            Title = "Shell Tab 1",
                        }
                    }
                }
            );

            var toggleHomeIndicatorButton2 = new Button()
            {
                Text = "Toggle Home Indicator",
                Command = new Command(() => On<iOS>().SetPrefersHomeIndicatorAutoHidden(!On<iOS>().PrefersHomeIndicatorAutoHidden()))
            };

            var contentPage2 = new ContentPage
            {
                Title = "Shell Tab 2",
                Content = new StackLayout()
                {
                    Margin = new Microsoft.Maui.Thickness(20),
                    Children =
                    {
                        toggleHomeIndicatorButton2,
                        new Button()
                        {
                            Text = "Navigate back",
                            Command = new Command(() => Navigation.PopAsync())
                        }
                    }
                }
            };

            toggleHomeIndicatorButton2.Command = new Command(() => contentPage2.On<iOS>().SetPrefersHomeIndicatorAutoHidden(!On<iOS>().PrefersHomeIndicatorAutoHidden()));

            tabBar.Items.Add
            (
                new Tab
                {
                    Title = "Shell Tab 2",
                    Items = {
                        new ShellContent
                        {
                            Content = contentPage2,
                            Title = "Shell Tab 2",
                        }
                    }
                }
            );

            Items.Add(tabBar);
        }
    }
}
