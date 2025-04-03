public class Rooms
{
    // public List<string> Countries { get; private set;} = new List<string>
    // {
    //     "Danmark",
    //     "Tyskland",
    //     "Sverige",
    //     "Norge",
    //     "Nederlandene"
    // };

    public static List<Room> RoomsList { get; private set; } = new List<Room>
    {
        new("Danmark", 1, 15, new List<string>{"Projekter", "Whiteboard"}),
        new("Danmark", 2, 20, new List<string>{"Whiteboard"}),
    };

    public Rooms()
    {
    }

    private void CreateRooms()
    {
        
    }

    public List<Room> GetRooms()
    {
        return RoomsList;
    }
}