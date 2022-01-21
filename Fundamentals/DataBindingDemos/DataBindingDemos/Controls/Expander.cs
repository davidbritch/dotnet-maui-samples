namespace DataBindingDemos
{
    // This is a hack until the Expander is present in .NET MAUI Community Toolkit.
    // It's not pretty, but it illustrates the point.
    public class Expander : Grid
    {
        public static readonly BindableProperty IsExpandedProperty = BindableProperty.Create(nameof(IsExpanded), typeof(bool), typeof(Expander), false);
    
        public bool IsExpanded
        {
            get => (bool)GetValue(IsExpandedProperty);
            set => SetValue(IsExpandedProperty, value);
        }
    }
}
