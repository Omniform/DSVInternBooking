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
}