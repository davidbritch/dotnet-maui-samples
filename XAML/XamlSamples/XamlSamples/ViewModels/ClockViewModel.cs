using System.ComponentModel;

namespace XamlSamples
{
    public class ClockViewModel : INotifyPropertyChanged
    {
        DateTime dateTime;
        public event PropertyChangedEventHandler PropertyChanged;

        public ClockViewModel()
        {
            this.DateTime = DateTime.Now;
            Timer timer = new Timer(new TimerCallback((s) => this.DateTime = DateTime.Now), null, 0, 1000);
        }

        public DateTime DateTime
        {
            get
            {
                return dateTime;
            }
            set
            {
                if (dateTime != value)
                {
                    dateTime = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("DateTime"));
                    }
                }
            }
        }
    }
}
