using Hotel_Reservation_System.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hotel_Reservation_System.Models
{
    public class Room
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public int Type { get; set; }
        public bool Isactive { get; set; }

        public DateTime Date { get; set; }

        public string[] Types => new string[] { "First Class", "2nd Class", "Third Class" };

        //[NotMapped]
        //public virtual List<Room> Rooms => new Hotel_Reservation_SystemContext().Room.ToList();

        public virtual List<Room_Usage> Usages => new Hotel_Reservation_SystemContext().Room_Usage.ToList().Where(x => x.Room_Id == Id).ToList();
    }
}
