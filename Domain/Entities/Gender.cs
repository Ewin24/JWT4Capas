using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Gender : BaseEntityInt
    {

        public string GenderName { get; set; }
        public ICollection<Person> Persons { get; set; }

    }
}