using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class PersonType
    {
        public int IdPersonType { get; set; }
        public string TypePersonDescription { get; set; }
        public ICollection<Person> Persons { get; set; }


    }
}