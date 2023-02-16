using Hotel_Reservation_System.Data;

namespace Hotel_Reservation_System.Models
{
    public class Room_Usage
    {
        public int Id { get; set; }

        public int Room_Id { get; set; }

        public int Guest_Id { get; set; }
        public bool Isactive { get; set; }

        public DateTime Date { get; set; }


        public virtual Room Room => new Hotel_Reservation_SystemContext().Room.Find(Room_Id);
        public virtual Guest Guest => new Hotel_Reservation_SystemContext().Guest.Find(Guest_Id);
    }
}
