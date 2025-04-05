using DSVInternBooking.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DSVInternBooking.Pages
{
    public class CreateBookingModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public int ID { get; set; }

        [BindProperty(SupportsGet = true)]
        public string Country { get; set; }

        [BindProperty]
        public Booking Booking { get; set; }

        private RoomService m_roomService = new RoomService();

        // public List<Room> SelectedCountryRoom { get; set; }
        [BindProperty]
        public Room SelectedRoom { get; set; }

        // public BookingService bookingService = new BookingService();

        private readonly BookingService m_bookingService;

        public CreateBookingModel(RoomService roomService, BookingService bookingService)
        => (m_roomService, m_bookingService) = (roomService, bookingService);

        public void OnGet()
        {
            Booking = new Booking();
            foreach (Room room in m_roomService.GetRooms())
            {
                if (room.Country == Country && room.ID == ID)
                {
                    SelectedRoom = room;
                    break;
                }
            }
            Booking.Room = SelectedRoom;
        }

        public IActionResult OnPostBook()
        {
            foreach (Room room in m_roomService.GetRooms())
            {
                if (room.ID == Booking.Room.ID && room.Country == Booking.Room.Country)
                {
                    Booking.Room = room;
                    break;
                }
            }

            m_bookingService.AddBooking(Booking);

            return RedirectToPage("MyBookings");
        }
    }
}
