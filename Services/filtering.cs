public class Filtering
{
    public Filtering()
    {
    }

    public List<string> FilterList(List<string> list, string filter)
    {
        List<string> nameSearch = new List<string>();

        foreach (string s in list)
        {
            if (s.ToLower().Contains(filter.ToLower()))
            {
                nameSearch.Add(s);
            }
        }

        return nameSearch;
    }

    public List<Room> FilterList(List<Room> list, string filter)
    {
        List<Room> nameSearch = new List<Room>();

        foreach (Room room in list)
        {
            if (room.EquipmentToString().ToLower().Contains(filter.ToLower()))
            {
                nameSearch.Add(room);
            }
        }

        return nameSearch;
    }
}