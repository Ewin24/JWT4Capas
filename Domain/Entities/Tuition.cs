using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Tuition
    {
        public int IdTuition { get; set; }
        public string IdPersonFk { get; set; }
        public Person Person { get; set; }
        public string IdRoomFk { get; set; }
        public Room Room { get; set; }
    }
}