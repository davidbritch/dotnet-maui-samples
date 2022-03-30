using Microsoft.Maui.Controls.PlatformConfiguration;
using Microsoft.Maui.Controls.PlatformConfiguration.AndroidSpecific;
using Button = Microsoft.Maui.Controls.Button;
using ListView = Microsoft.Maui.Controls.ListView;
using ViewCell = Microsoft.Maui.Controls.ViewCell;

namespace PlatformSpecifics
{
    public class AndroidViewCellPageCS : ContentPage
    {
        public AndroidViewCellPageCS()
        {
            Button button = new Button
            {
                Text = "Toggle Legacy Mode"
            };
            button.SetBinding(Button.CommandProperty, "ToggleLegacyMode");

            DataTemplate oneItemTemplate = new DataTemplate(() =>
            {
                Label label = new Label();
                label.SetBinding(Label.TextProperty, "Text");

                ViewCell viewCell = new ViewCell
                {
                    View = label
                };
                button.Clicked += (s, e) =>
                {
                    viewCell.On<Microsoft.Maui.Controls.PlatformConfiguration.Android>().SetIsContextActionsLegacyModeEnabled(!viewCell.On<Microsoft.Maui.Controls.PlatformConfiguration.Android>().GetIsContextActionsLegacyModeEnabled());
                };

                MenuItem menuItem = new MenuItem();
                menuItem.SetBinding(MenuItem.TextProperty, "Item1Text");
                
                viewCell.ContextActions.Add(menuItem);
                return viewCell;
            });

            DataTemplate twoItemsTemplate = new DataTemplate(() =>
            {
                Label label = new Label();
                label.SetBinding(Label.TextProperty, "Text");

                ViewCell viewCell = new ViewCell
                {
                    View = label
                };

                button.Clicked += (s, e) =>
                {
                    viewCell.On<Microsoft.Maui.Controls.PlatformConfiguration.Android>().SetIsContextActionsLegacyModeEnabled(!viewCell.On<Microsoft.Maui.Controls.PlatformConfiguration.Android>().GetIsContextActionsLegacyModeEnabled());
                };

                MenuItem menuItem1 = new MenuItem();
                menuItem1.SetBinding(MenuItem.TextProperty, "Item1Text");
                MenuItem menuItem2 = new MenuItem();
                menuItem2.SetBinding(MenuItem.TextProperty, "Item2Text");
                
                viewCell.ContextActions.Add(menuItem1);
                viewCell.ContextActions.Add(menuItem2);
                return viewCell;
            });

            ItemDataTemplateSelector itemDataTemplateSelector = new ItemDataTemplateSelector
            {
                OneItemTemplate = oneItemTemplate,
                TwoItemsTemplate = twoItemsTemplate
            };

            ListView listView = new ListView
            {
                ItemTemplate = itemDataTemplateSelector
            };
            listView.SetBinding(ItemsView<Cell>.ItemsSourceProperty, "Items");

            BindingContext = new AndroidViewCellPageViewModel();
            Title = "ViewCell Context Actions";
            Content = new StackLayout
            {
                Children =
                {
                    new StackLayout
                    {
                        Margin = new Thickness(20),
                        Children =
                        {
                            button,
                            listView
                        }
                    }
                }
            };
        }
    }
}
