using Microsoft.EntityFrameworkCore;
using MoqTutorial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoqTutorial.Data
{
    public class BookingDbContext: DbContext
    {
        public DbSet<Room> Rooms { get; set; }
    }
}
