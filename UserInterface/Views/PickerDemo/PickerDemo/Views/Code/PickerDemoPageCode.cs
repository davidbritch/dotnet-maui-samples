namespace PickerDemo
{
	public class PickerDemoPageCode : TabbedPage
	{
		public PickerDemoPageCode()
		{
			Children.Add(new PickerItemsSourcePageCode());
			Children.Add(new PickerItemsPageCode());
		}
	}
}
