using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Person
    {
        public string IdPersonType { get; set; }
        public string PersonName { get; set; }
        public int IdGenderFk { get; set; }
        public Gender Gender { get; set; }
        public int IdCityFk { get; set; }
        public City City { get; set; }
        public int IdPerTypeFk { get; set; }
        public PersonType PersonType { get; set; }
        public ICollection<Tuition> Tuitions { get; set; }
        public ICollection<TrainerRoom> TrainerRooms { get; set; }

    }
}