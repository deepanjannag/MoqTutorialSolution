using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoqTutorial.Exceptions
{
    public class RoomAlreadyReservedException: Exception
    {
        public RoomAlreadyReservedException(Guid roomId):base($"Room '{roomId}' is already reserved.")
        { }
    }
}
