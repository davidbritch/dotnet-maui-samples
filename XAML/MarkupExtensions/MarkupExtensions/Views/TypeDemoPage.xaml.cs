using System.Windows.Input;

namespace MarkupExtensions
{
    public partial class TypeDemoPage : ContentPage
    {
        public TypeDemoPage()
        {
            InitializeComponent();

            CreateCommand = new Command<Type>((Type viewType) =>
            {
                View view = (View)Activator.CreateInstance(viewType);
                view.VerticalOptions = LayoutOptions.Center;
                stackLayout.Add(view);
            });

            BindingContext = this;
        }

        public ICommand CreateCommand { private set; get; }
    }
}