using MoqTutorial.Exceptions;
using MoqTutorial.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoqTutorial
{
    public class ReservationSystem
    {
        private readonly IBookingService bookingService;

        public ReservationSystem(IBookingService bookingService)
        {
            this.bookingService = bookingService;
        }

        public async Task ReserveAsync(int amountOfBeds)
        {
            var rooms = await bookingService.GetRoomsAsync(amountOfBeds);

            var firstAvailableRoom = rooms.FirstOrDefault(room => !room.IsReserved);

            if (firstAvailableRoom is null)
            {
                throw new NoAvailableRoomsException(amountOfBeds);
            }

            await bookingService.ReserveRoomAsync(firstAvailableRoom.RoomId);
        }
    }
}
