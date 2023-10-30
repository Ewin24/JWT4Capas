using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Room
    {
        public string IdRoom { get; set; }
        public string RoomName { get; set; }
        public int Capacity { get; set; }
        public ICollection<Tuition> Tuitions { get; set; }
        public ICollection<TrainerRoom> TrainerRooms { get; set; }


    }
}