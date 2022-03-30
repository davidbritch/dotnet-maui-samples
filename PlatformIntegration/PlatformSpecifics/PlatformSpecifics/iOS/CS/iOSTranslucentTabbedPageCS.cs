using System.Windows.Input;
using Microsoft.Maui.Controls.PlatformConfiguration;
using Microsoft.Maui.Controls.PlatformConfiguration.iOSSpecific;

namespace PlatformSpecifics
{
    public class iOSTranslucentTabbedPageCS : Microsoft.Maui.Controls.TabbedPage
    {
        ICommand returnToPlatformSpecificsPage;

        public iOSTranslucentTabbedPageCS(ICommand restore)
        {
            returnToPlatformSpecificsPage = restore;
            On<iOS>().SetTranslucencyMode(TranslucencyMode.Opaque);

            ContentPage firstPage = CreatePage(1);
            StackLayout stackLayout = firstPage.Content as StackLayout;
            Microsoft.Maui.Controls.Button translucencyButton = new Microsoft.Maui.Controls.Button
            {
                Text = "Toggle TranslucencyMode"
            };
            translucencyButton.Clicked += (sender, e) =>
            {
                switch (On<iOS>().GetTranslucencyMode())
                {
                    case TranslucencyMode.Default:
                        On<iOS>().SetTranslucencyMode(TranslucencyMode.Translucent);
                        break;
                    case TranslucencyMode.Translucent:
                        On<iOS>().SetTranslucencyMode(TranslucencyMode.Opaque);
                        break;
                    case TranslucencyMode.Opaque:
                        On<iOS>().SetTranslucencyMode(TranslucencyMode.Default);
                        break;
                }
            };

            stackLayout.Add(translucencyButton);

            Title = "TabbedPage Translucent TabBar";
            Children.Add(firstPage);
            Children.Add(CreatePage(2));
            Children.Add(CreatePage(3));
        }

        ContentPage CreatePage(int pageNumber)
        {
            var returnButton = new Microsoft.Maui.Controls.Button { Text = "Return to Platform-Specifics List" };
            returnButton.Clicked += (sender, e) => returnToPlatformSpecificsPage.Execute(null);

            return new ContentPage
            {
                Title = string.Format("Page {0}", pageNumber),
                IconImageSource = "csharp.png",
                Content = new StackLayout
                {
                    Margin = new Thickness(20,35,20,20),
                    Children = {
                        new Label { Text = string.Format("Page {0}", pageNumber), HorizontalOptions = LayoutOptions.Center },
                        returnButton
                    }
                }
            };
        }
    }
}
