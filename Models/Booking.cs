namespace DSVInternBooking.Models
{
    public class Booking
    {
        public Booking()
        {
        }
        public Booking(DateTime dateTimeBegin, DateTime dateTimeEnd, Room room)
            => (DateTimeBegin, DateTimeEnd, Room) = (dateTimeBegin, dateTimeEnd, room);
        public DateTime DateTimeBegin { get; set; }
        public DateTime DateTimeEnd { get; set; }
        public Room Room { get; set; }
    }
}
