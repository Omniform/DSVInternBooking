using System.Reflection.Metadata;
using DSVInternBooking.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp.Namespace
{
    public class GetAllRoomsModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public string Country { get; set; }
        private List<Room> m_rooms = new List<Room>();
        private RoomService m_roomService = new RoomService();
        public List<Room> m_selectedCountryRooms = new List<Room>();

        // public bool IsBooked { get; set; }

        public string StyleButton { get; set; }

        public string RedirectBookingPage { get; set; }

        private Filtering filtering = new Filtering();

        public BookingService bookingService { get; set; }

        [BindProperty]
        public string SearchString { get; set; }

        public GetAllRoomsModel(RoomService roomService)
        => m_roomService = roomService;

        public string Parameter { get; set; }


        public void OnGet()
        {
            bookingService = new BookingService();
            m_selectedCountryRooms = m_roomService.GetRooms().Where(room => room.Country == Country).ToList();
        }

        public async Task<IActionResult> OnPostNameSearchAsync(string SearchString)
        {
            m_selectedCountryRooms = m_roomService.GetRooms().Where(room => room.Country == Country).ToList();

            if (!string.IsNullOrEmpty(SearchString))
            {
                m_selectedCountryRooms = filtering.FilterList(m_selectedCountryRooms, SearchString);
            }

            return Page();
        }
    }
}
