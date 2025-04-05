using DSVInternBooking.Models;

public class BookingService
{
  public List<Booking> BookedRooms { get; private set; }
  public BookingService()
  {
    BookedRooms = new List<Booking>();
  }

  public bool Contains(Booking booking)
  {
    return BookedRooms.Contains(booking);
  }

  public bool Contains(Room room)
  {
    foreach (Booking booking in BookedRooms)
    {
      if (booking.Room == room)
      {
        return true;
      }
    }

    return false;
  }


  public void AddBooking(Booking booking)
  {
    BookedRooms.Add(booking);
  }

  public void RemoveBooking(Booking booking)
  {
    BookedRooms.Remove(booking);
  }
}