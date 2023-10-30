using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class State
    {
        public string IdState { get; set; }
        public string StateName { get; set; }
        public string IdCountryFk { get; set; }
        public ICollection<City> Cities { get; set; }
    }
}