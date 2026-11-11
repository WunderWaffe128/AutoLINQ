using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal class Brand
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public int FoundedYear { get; set; }

        public Brand(string name, string country, int foundedYear)
        {
            Name = name;
            Country = country;
            FoundedYear = foundedYear;

        }
    }
}
