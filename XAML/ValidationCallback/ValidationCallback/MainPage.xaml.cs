namespace ValidationCallback;

public partial class MainPage : ContentPage
{
    public static readonly BindableProperty AngleProperty = BindableProperty.Create("Angle", typeof(double), typeof(MainPage), 0.0, validateValue: IsValidValue);

    public double Angle
    {
        get { return (double)GetValue(AngleProperty); }
        set
        {
            if (IsValidValue(null, value))
            {
                SetValue(AngleProperty, value);
            }
        }
    }

    public MainPage()
	{
		InitializeComponent();
	}

    static bool IsValidValue(BindableObject view, object value)
    {
        double result;
        double.TryParse(value.ToString(), out result);
        return (result >= 0 && result <= 360);
    }
}
