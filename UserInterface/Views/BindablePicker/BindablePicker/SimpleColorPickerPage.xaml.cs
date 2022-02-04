namespace BindablePicker
{
	public partial class SimpleColorPickerPage : ContentPage
	{
		public SimpleColorPickerPage()
		{
			InitializeComponent();
			BindingContext = new SimpleColorPickerPageViewModel
            {
				SelectedColorName = "Black"
            };
		}
	}
}
