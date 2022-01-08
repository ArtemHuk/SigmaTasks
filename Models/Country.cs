using System;
using System.Collections.Generic;
namespace Task15.Models
{
    public class Country
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public ICollection<City> Cities { get; set; }

        public Country()
        {
            Cities = new HashSet<City>();
        }
    }
}
