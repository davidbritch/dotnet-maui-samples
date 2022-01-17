using System.ComponentModel;

namespace DataBindingDemos
{
    public class RgbColorViewModel : INotifyPropertyChanged
    {
        Color color;
        string name; 

        public event PropertyChangedEventHandler PropertyChanged;

        public float Red
        {
            set
            {
                if (color.Red != value)
                {
                    Color = new Color(value, color.Green, color.Blue);
                }
            }
            get 
            {
                return color.Red;
            }
        }

        public float Green
        {
            set
            {
                if (color.Green != value)
                {
                    Color = new Color(color.Red, value, color.Blue);
                }
            }
            get
            {
                return color.Green;
            }
        }

        public float Blue
        {
            set
            {
                if (color.Blue != value)
                {
                    Color = new Color(color.Red, color.Green, value);
                }
            }
            get
            {
                return color.Blue;
            }
        }

        public Color Color
        {
            set
            {
                if (color != value)
                {
                    color = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Red"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Green"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Blue"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Color"));

                    Name = NamedColor.GetNearestColorName(color);
                }
            }
            get
            {
                return color;
            }
        }

        public string Name
        {
            private set
            {
                if (name != value)
                {
                    name = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
                }
            }
            get
            {
                return name;
            }
        }
    }
}
