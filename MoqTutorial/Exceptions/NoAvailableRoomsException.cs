using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoqTutorial.Exceptions
{
    public class NoAvailableRoomsException: Exception
    {
        public NoAvailableRoomsException(int beds) : base($"No available rooms with {beds} beds.")
        { }
    }
}
