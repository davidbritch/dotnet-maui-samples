namespace StepperDemo
{
    public partial class BasicStepperXAMLPage : ContentPage
    {
        public BasicStepperXAMLPage()
        {
            InitializeComponent();
        }

        void OnStepperValueChanged(object sender, ValueChangedEventArgs e)
        {
            double value = e.NewValue;
            rotatingLabel.Rotation = value;
            displayLabel.Text = string.Format("The Stepper value is {0}", value);
        }
    }
}
