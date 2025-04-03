using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp.Namespace
{
    public class GetAllRoomsModel : PageModel
    {
        private List<Room> m_rooms = new List<Room>();
        private RoomService m_roomService = new RoomService();
        public List<Room> m_selectedCountryRooms = new List<Room>();

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
    }
}
