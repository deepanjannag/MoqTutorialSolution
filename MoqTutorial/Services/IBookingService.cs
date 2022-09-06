using MoqTutorial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoqTutorial.Services
{
    public interface IBookingService
    {
        public Task<IEnumerable<Room>> GetRoomsAsync(int beds);
        public Task ReserveRoomAsync(Guid roomId);
    }
}
