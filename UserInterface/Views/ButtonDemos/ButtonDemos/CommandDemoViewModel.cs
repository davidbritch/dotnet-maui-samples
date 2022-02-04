using System.ComponentModel;
using System.Windows.Input;

namespace ButtonDemos
{
    public class CommandDemoViewModel : INotifyPropertyChanged
    {
        double number = 1;

        public event PropertyChangedEventHandler PropertyChanged;


        public ICommand MultiplyBy2Command { get; private set; }

        public ICommand DivideBy2Command { get; private set; }

        public CommandDemoViewModel()
        {
            MultiplyBy2Command = new Command(() => Number *= 2);
            DivideBy2Command = new Command(() => Number /= 2);
        }

        public double Number
        {
            get
            {
                return number;
            }
            set
            {
                if (number != value)
                {
                    number = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Number"));
                }
            }
        }
    }
}
