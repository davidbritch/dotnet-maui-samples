using System.Reflection;
using System.Text;

namespace ButtonDemos
{
    public class NamedColor 
    {
        static StringBuilder stringBuilder = new StringBuilder();

        public string Name { private set; get; }
        public string FriendlyName { private set; get; }
        public Color Color { private set; get; }
        public string RgbDisplay { private set; get; }

        // Static members.
        static NamedColor()
        {
            List<NamedColor> all = new List<NamedColor>();

            // Loop through the public static properties of the Color structure.
            foreach (PropertyInfo propInfo in typeof(Colors).GetRuntimeProperties())
            {
                if (propInfo.GetMethod.IsPublic &&
                    propInfo.GetMethod.IsStatic &&
                    propInfo.PropertyType == typeof(Color))
                {
                    all.Add(CreateNamedColor(propInfo.Name, (Color)propInfo.GetValue(null)));
                }
            }

            // Loop through the public static fields of the Color structure.
            foreach (FieldInfo fieldInfo in typeof(Colors).GetRuntimeFields())
            {
                if (fieldInfo.IsPublic &&
                    fieldInfo.IsStatic &&
                    fieldInfo.FieldType == typeof (Color))
                {
                    all.Add(CreateNamedColor(fieldInfo.Name, (Color)fieldInfo.GetValue(null)));
                }
            }
            all.TrimExcess();
            All = all;
        }

        public static IList<NamedColor> All { private set; get; }

        static NamedColor CreateNamedColor(string name, Color color)
        {
            // Convert the name to a friendly name.
            stringBuilder.Clear();
            int index = 0;

            foreach (char ch in name)
            {
                if (index != 0 && Char.IsUpper(ch))
                {
                    stringBuilder.Append(' ');
                }
                stringBuilder.Append(ch);
                index++;
            }

            NamedColor namedColor = new NamedColor
            {
                Name = name,
                FriendlyName = stringBuilder.ToString(),
                Color = color,
                RgbDisplay = String.Format("{0:X2}-{1:X2}-{2:X2}",
                                           (int)(255 * color.Red),
                                           (int)(255 * color.Green),
                                           (int)(255 * color.Blue))
            };

            return namedColor;
        }
    }
}
