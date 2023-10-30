using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class City
    {
        public string IdCity { get; set; }
        public string CityName { get; set; }
        public string IdStateFk { get; set; }
        public State State { get; set; }
        public ICollection<Person> Persons { get; set; }

    }
}