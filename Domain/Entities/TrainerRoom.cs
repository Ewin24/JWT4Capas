using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class TrainerRoom : BaseEntityInt
    {
        public string IdPerTrainerFk { get; set; }
        public Person Person { get; set; }
        public int IdRoomFk { get; set; }
        public Room Room { get; set; }
    }
}