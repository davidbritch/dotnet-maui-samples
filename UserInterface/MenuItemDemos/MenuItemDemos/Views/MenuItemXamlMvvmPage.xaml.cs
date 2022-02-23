using MenuItemDemos.Services;
using MenuItemDemos.ViewModels;

namespace MenuItemDemos
{
    public partial class MenuItemXamlMvvmPage : ContentPage
    {
        public MenuItemXamlMvvmPage()
        {
            InitializeComponent();

            BindingContext = new ListPageViewModel(DataService.GetListItems());
        }
    }
}