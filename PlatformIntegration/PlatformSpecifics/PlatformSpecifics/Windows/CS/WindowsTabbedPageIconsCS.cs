using System.Windows.Input;
using Microsoft.Maui.Controls.PlatformConfiguration.WindowsSpecific;

namespace PlatformSpecifics
{
	public class WindowsTabbedPageIconsCS : Microsoft.Maui.Controls.TabbedPage
	{
        ICommand _returnToPlatformSpecificsPage;

        public WindowsTabbedPageIconsCS (ICommand restore)
		{
            _returnToPlatformSpecificsPage = restore;

            On<Microsoft.Maui.Controls.PlatformConfiguration.Windows>().SetHeaderIconsEnabled(true);
            On<Microsoft.Maui.Controls.PlatformConfiguration.Windows>().SetHeaderIconsSize(new Size(24, 24));

            Children.Add(CreatePage("Todo", "todo.png"));
            Children.Add(CreatePage("Reminders", "reminders.png"));
            Children.Add(CreatePage("Contacts", "contacts.png"));
        }

        ContentPage CreatePage(string title, string icon)
        {
            var toggleButton = new Microsoft.Maui.Controls.Button { Text = "Toggle Header Icons" };
            toggleButton.Clicked += (sender, e) => On<Microsoft.Maui.Controls.PlatformConfiguration.Windows>().SetHeaderIconsEnabled(!On<Microsoft.Maui.Controls.PlatformConfiguration.Windows>().GetHeaderIconsEnabled());

            var returnButton = new Microsoft.Maui.Controls.Button { Text = "Return to Platform-Specifics List" };
            returnButton.Clicked += (sender, e) => _returnToPlatformSpecificsPage.Execute(null);

            return new ContentPage
            {
                Title = title,
                IconImageSource = icon,
                Content = new StackLayout
                {
                    Margin = new Thickness(20),
                    Children = {
                        new Microsoft.Maui.Controls.Label { Text = $"This is the {title} page." },
                        toggleButton,
                        returnButton
                    }
                }
            };
        }
    }
}
