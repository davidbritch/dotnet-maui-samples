using System.ComponentModel;

namespace DataBindingDemos
{
    public class HslColorViewModel : INotifyPropertyChanged
    {
        Color color;
        string name; 

        public event PropertyChangedEventHandler PropertyChanged;

        public float Hue
        {
            set
            {
                if (color.GetHue() != value)
                {
                    Color = Color.FromHsla(value, color.GetSaturation(), color.GetLuminosity());
                }
            }
            get 
            {
                return color.GetHue();
            }
        }

        public float Saturation
        {
            set
            {
                if (color.GetSaturation() != value)
                {
                    Color = Color.FromHsla(color.GetHue(), value, color.GetLuminosity());
                }
            }
            get
            {
                return color.GetSaturation();
            }
        }

        public float Luminosity
        {
            set
            {
                if (color.GetLuminosity() != value)
                {
                    Color = Color.FromHsla(color.GetHue(), color.GetSaturation(), value);
                }
            }
            get
            {
                return color.GetLuminosity();
            }
        }

        public Color Color
        {
            set
            {
                if (color != value)
                {
                    color = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Hue"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Saturation"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Luminosity"));
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
