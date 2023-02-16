using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Hotel_Reservation_System.Models;

namespace Hotel_Reservation_System.Data
{
    public class Hotel_Reservation_SystemContext : DbContext
    {
        public Hotel_Reservation_SystemContext()
        {
        }

        public Hotel_Reservation_SystemContext (DbContextOptions<Hotel_Reservation_SystemContext> options)
            : base(options)
        {
        }

        public DbSet<Hotel_Reservation_System.Models.Guest> Guest { get; set; } = default!;

        public DbSet<Hotel_Reservation_System.Models.Room> Room { get; set; }

        public DbSet<Hotel_Reservation_System.Models.Room_Usage> Room_Usage { get; set; }
      
    }
}
