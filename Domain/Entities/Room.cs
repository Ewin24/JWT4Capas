using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Room : BaseEntityString
    {

        public string RoomName { get; set; }
        public int Capacity { get; set; }
        public ICollection<Tuition> Tuitions { get; set; }
        public ICollection<TrainerRoom> TrainerRooms { get; set; }


    }
}