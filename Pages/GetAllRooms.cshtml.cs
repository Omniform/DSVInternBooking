using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp.Namespace
{
    public class GetAllRoomsModel : PageModel
    {
        public List<Room> m_rooms = new List<Room>();
        private RoomService m_roomService = new RoomService();
        private List<Room> m_selectedCountryRooms = new List<Room>();

        public GetAllRoomsModel(RoomService roomService)
        => m_roomService = roomService;

        public void OnGet()
        {
            m_rooms = m_roomService.GetRooms();
        }
    }
}
