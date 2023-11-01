using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class State : BaseEntityString
    {
        public string StateName { get; set; }
        public string IdCountryFk { get; set; }
        public Country Country { get; set; }
        public ICollection<City> Cities { get; set; }
    }
}