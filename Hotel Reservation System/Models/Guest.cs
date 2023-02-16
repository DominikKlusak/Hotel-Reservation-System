using Hotel_Reservation_System.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hotel_Reservation_System.Models
{
    public class Guest
    {
        public int Id { get; set; }
        public string Names { get; set; }

        public string PhoneNumber { get; set; }

        public string Address { get; set; }

        public string Email { get; set; }
        public string Password { get; set; }

        public bool Isactive { get; set; }

        public DateTime Date { get; set; }

        //[NotMapped]
       // public virtual List<Guest> Guests => new Hotel_Reservation_SystemContext().Guest.ToList();

        public virtual List<Room_Usage> Usages => new Hotel_Reservation_SystemContext().Room_Usage.ToList().Where(x => x.Guest_Id == Id).ToList();


    }
}
