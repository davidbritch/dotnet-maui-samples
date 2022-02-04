using Microsoft.Maui.Graphics.Converters;
using System.Reflection;

namespace BindablePicker
{
    public class SimpleColorPickerPageViewModel : ViewModelBase
	{
		ColorTypeConverter colorTypeConverter = new ColorTypeConverter();

		public IList<string> ColorNames
		{
			get
			{
				return typeof(Colors).GetRuntimeFields()
									.Where(f => f.IsPublic && f.IsStatic)
									.Select(f => f.Name).ToList();
			}
		}

		string selectedColorName;
		public string SelectedColorName
		{
			get { return selectedColorName; }
			set
			{
				if (selectedColorName != value)
				{
					selectedColorName = value;
					OnPropertyChanged();
					OnPropertyChanged("SelectedColor");
				}
			}
		}

		public Color SelectedColor
		{
			get
			{
				if (string.IsNullOrWhiteSpace(selectedColorName))
				{
					return Colors.Black;
				}
				return (Color)colorTypeConverter.ConvertFromInvariantString(selectedColorName);
			}
		}
	}
}
