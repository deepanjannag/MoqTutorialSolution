using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoqTutorial.Models
{
    public class Room
    {
        public Guid     RoomId      { get; set; } = Guid.NewGuid();
        public string   RoomName    { get; set; }
        public int      Beds        { get; set; }
        public bool     IsReserved  { get; set; } = false;
    }
}
