﻿using System.Collections.ObjectModel;

namespace PlatformSpecifics
{
    public class ListViewViewModel
    {
        public ObservableCollection<Grouping<char, Person>> GroupedEmployees { get; set; }

        public ListViewViewModel(int num=2000)
        {
            var rnd = new Random();
            var employees = new List<Person>();
            Enumerable.Range(0, num)
                      .Select(p => new Person(string.Format("{0}, {1}", Faker.NameFaker.LastName(), Faker.NameFaker.FirstName()), rnd.Next(18, 65)))
                      .ForEach(p => employees.Add(p));
            GroupedEmployees = new ObservableCollection<Grouping<char, Person>>(employees.OrderBy(e => e.Name[0]).GroupBy(e => e.Name[0]).Select(e => new Grouping<char, Person>(e.Key, e)));
        }
    }
}
