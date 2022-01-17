namespace CoerceValueCallback;

public partial class MainPage : ContentPage
{
    public static readonly BindableProperty AngleProperty = BindableProperty.Create("Angle", typeof(double), typeof(MainPage), 0.0, coerceValue: CoerceAngle);
    public static readonly BindableProperty MaximumAngleProperty = BindableProperty.Create("MaximumAngle", typeof(double), typeof(MainPage), 360.0, propertyChanged: ForceCoerceValue);

    public double Angle
    {
        get { return (double)GetValue(AngleProperty); }
        set { SetValue(AngleProperty, value); }
    }

    public double MaximumAngle
    {
        get { return (double)GetValue(MaximumAngleProperty); }
        set { SetValue(MaximumAngleProperty, value); }
    }

    public MainPage()
	{
		InitializeComponent();
	}

    static object CoerceAngle(BindableObject bindable, object value)
    {
        MainPage page = bindable as MainPage;
        double input = (double)value;

        if (input > page.MaximumAngle)
        {
            input = page.MaximumAngle;
        }

        return input;
    }

    static void ForceCoerceValue(BindableObject bindable, object oldValue, object newValue)
    {
        bindable.CoerceValue(AngleProperty);
    }
}
