using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp.Namespace
{
    public class GetAllRoomsModel : PageModel
    {
        private List<Room> m_rooms = new List<Room>();
        private RoomService m_roomService = new RoomService();
        public List<Room> m_selectedCountryRooms = new List<Room>();

        private Filtering filtering = new Filtering();

        [BindProperty]
        public string SearchString { get; set; }

        public GetAllRoomsModel(RoomService roomService)
        => m_roomService = roomService;

        public string Parameter { get; set; }

        public void OnGet()
        {
            m_rooms = m_roomService.GetRooms();

            Parameter = Request.Query["country"];

            foreach (Room room in m_rooms)
            {
                if (room.Country == Parameter)
                {
                    m_selectedCountryRooms.Add(room);
                }
            }
        }

        public IActionResult OnPostNameSearch()
        {
            if (SearchString != null)
            {
                m_selectedCountryRooms = filtering.FilterList(m_selectedCountryRooms, SearchString);
            }
            return Page();
        }
    }
}
