public class RoomService
{
    public List<Room> RoomServices { get; private set; } = new List<Room>();

    private Rooms m_rooms = new Rooms();
    
    public RoomService()
    {
        RoomServices = m_rooms.GetRooms();
    }

    public List<Room> GetRooms()
    {
        return RoomServices;
    }

    public Room GetRoomByIDAndCountry(int id, string country)
    {
        foreach (Room room in RoomServices)
        {
            if (room.ID == id && room.Country == country)
            {
                return room;
            }
        }
        return RoomServices.ElementAt(0);
    }
}