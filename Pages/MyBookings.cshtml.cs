using DSVInternBooking.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DSVInternBooking.Pages
{
    public class MyBookingsModel : PageModel
    {
        [BindProperty]
        public string Country { get; set; }
        [BindProperty]
        public int ID { get; set; }

        public BookingService BookingService { get; set; }

        public MyBookingsModel(BookingService bookingService)
        => BookingService = bookingService;
        
        public void OnGet()
        {
        }

        public void OnPostRemove()
        {
            foreach (Booking booking in BookingService.BookedRooms)
            {
                if (Country == booking.Room.Country && ID == booking.Room.ID)
                {
                    BookingService.RemoveBooking(booking);
                    break;
                }
            }
        }
    }
}
