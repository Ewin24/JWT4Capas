using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Gender
    {
        public int IdGenderFk { get; set; }
        public string GenderName { get; set; }
        public ICollection<Person> Persons { get; set; }

    }
}