using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoqTutorial.Exceptions
{
    public class RoomNotFoundException: Exception
    {
        public RoomNotFoundException(Guid roomId) : base($"Room '{roomId}' does not exist.") 
        { }
    }
}
