using System.Reflection.Metadata;
using System.Text.Json;
using System.Text.Json.Serialization;

public class Rooms
{
    public static List<Room> RoomsList { get; private set; } = new List<Room>()
    {
        new("Danmark", 1, 15, new List<string>{"Projekter", "Whiteboard"}),
        new("Danmark", 2, 20, new List<string>{"Whiteboard"}),
        new("Tyskland", 4, 20, new List<string>{"Whiteboard"}),
        new("Nederlandene", 2, 20, new List<string>{"Whiteboard"})
    };

    public Rooms()
    {
        // Room room = ReadJson<Room>("./Data/rooms.json");
        // RoomsList.Add(room);
    }

    // private T ReadJson<T>(in string filePath)
    // {
    //     string text = File.ReadAllText(filePath);
    //     return JsonSerializer.Deserialize<T>(text);
    // }

    public List<Room> GetRooms()
    {
        return RoomsList;
    }
}