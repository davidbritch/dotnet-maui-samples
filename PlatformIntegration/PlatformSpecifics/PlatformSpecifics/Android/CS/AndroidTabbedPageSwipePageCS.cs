using System.Windows.Input;
using Microsoft.Maui.Controls.PlatformConfiguration;
using Microsoft.Maui.Controls.PlatformConfiguration.AndroidSpecific;

namespace PlatformSpecifics
{
    public class AndroidTabbedPageSwipePageCS : Microsoft.Maui.Controls.TabbedPage
    {
        ICommand _returnToPlatformSpecificsPage;

        public AndroidTabbedPageSwipePageCS(ICommand restore)
        {
            _returnToPlatformSpecificsPage = restore;

            On<Microsoft.Maui.Controls.PlatformConfiguration.Android>().SetOffscreenPageLimit(2)
                         .SetIsSwipePagingEnabled(true)
                         .SetIsSmoothScrollEnabled(false)
                         .SetToolbarPlacement(ToolbarPlacement.Bottom);

            var firstPage = CreatePage(1);
            var stackLayout = firstPage.Content as StackLayout;
            var swipePagingButton = new Microsoft.Maui.Controls.Button
            {
                Text = "Toggle Swipe Paging"
            };
            swipePagingButton.Clicked += (sender, e) =>
            {
                On<Microsoft.Maui.Controls.PlatformConfiguration.Android>().SetIsSwipePagingEnabled(!On<Microsoft.Maui.Controls.PlatformConfiguration.Android>().IsSwipePagingEnabled());
            };
            var smoothScrollButton = new Microsoft.Maui.Controls.Button
            {
                Text = "Toggle Smooth Scroll"
            };
            smoothScrollButton.Clicked += (sender, e) =>
            {
                On<Microsoft.Maui.Controls.PlatformConfiguration.Android>().SetIsSmoothScrollEnabled(!On<Microsoft.Maui.Controls.PlatformConfiguration.Android>().IsSmoothScrollEnabled());
            };

            stackLayout.Add(swipePagingButton);
            stackLayout.Add(smoothScrollButton);

            Title = "TabbedPage";
            Children.Add(firstPage);
            Children.Add(CreatePage(2));
            Children.Add(CreatePage(3));
            Children.Add(CreatePage(4));
            Children.Add(CreatePage(5));
        }

        ContentPage CreatePage(int pageNumber)
        {
            var returnButton = new Microsoft.Maui.Controls.Button { Text = "Return to Platform-Specifics List" };
            returnButton.Clicked += (sender, e) => _returnToPlatformSpecificsPage.Execute(null);

            return new ContentPage
            {
                Title = string.Format("Page {0}", pageNumber),
                IconImageSource = "csharp.png",
                Content = new StackLayout
                {
                    Margin = new Thickness(20),
                    Children = {
                        new Label { Text = string.Format("Page {0}", pageNumber), HorizontalOptions = LayoutOptions.Center },
                        returnButton
                    }
                }
            };
        }
    }
}
