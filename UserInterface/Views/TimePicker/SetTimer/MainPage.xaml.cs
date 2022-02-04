using System.ComponentModel;

namespace SetTimer;

public partial class MainPage : ContentPage
{
    DateTime triggerTime;

    public MainPage()
    {
        InitializeComponent();

        Device.StartTimer(TimeSpan.FromSeconds(1), OnTimerTick);
    }

    bool OnTimerTick()
    {
        if (mySwitch.IsToggled && DateTime.Now >= triggerTime)
        {
            mySwitch.IsToggled = false;
            DisplayAlert("Timer Alert", "The '" + entry.Text + "' timer has elapsed", "OK");
        }
        return true;
    }

    void OnTimePickerPropertyChanged(object sender, PropertyChangedEventArgs args)
    {
        if (args.PropertyName == "Time")
        {
            SetTriggerTime();
        }
    }

    void OnSwitchToggled(object sender, ToggledEventArgs args)
    {
        SetTriggerTime();
    }

    void SetTriggerTime()
    {
        if (mySwitch.IsToggled)
        {
            triggerTime = DateTime.Today + _timePicker.Time;
            if (triggerTime < DateTime.Now)
            {
                triggerTime += TimeSpan.FromDays(1);
            }
        }
    }
}