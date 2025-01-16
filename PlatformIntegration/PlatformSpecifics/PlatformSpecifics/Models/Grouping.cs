using System.Collections.ObjectModel;

namespace PlatformSpecifics
{
    public class Grouping<K, T> : ObservableCollection<T>
    {
        public K Key { get; set; }

        public Grouping(K key, IEnumerable<T> items)
        {
            Key = key;
            foreach (T item in items)
            {
                Items.Add(item);
            }
        }
    }
}
