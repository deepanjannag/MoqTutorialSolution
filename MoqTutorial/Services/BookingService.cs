using Microsoft.EntityFrameworkCore;
using MoqTutorial.Data;
using MoqTutorial.Exceptions;
using MoqTutorial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoqTutorial.Services
{
    public class BookingService : IBookingService
    {
        private readonly BookingDbContext db;

        public BookingService(BookingDbContext db)
        {
            this.db = db;
        }

        public async Task<IEnumerable<Room>> GetRoomsAsync(int beds)
        {
            return await db.Rooms.Where(r => r.Beds >= beds).AsNoTracking().ToListAsync();
        }

        public async Task ReserveRoomAsync(Guid roomId)
        {
            var room = await db.Rooms.FirstOrDefaultAsync(r => r.RoomId == roomId);

            if (room == null)            
                throw new RoomNotFoundException(roomId);
            

            if (room.IsReserved)            
                throw new RoomAlreadyReservedException(roomId);
            

            room.IsReserved = true;

            await db.SaveChangesAsync();
        }
    }
}
