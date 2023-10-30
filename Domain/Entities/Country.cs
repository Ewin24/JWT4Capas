using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Country
    {
        public string IdCountry { get; set; }
        public string CountryName { get; set; }

        public ICollection<State> States { get; set; }
    }
}