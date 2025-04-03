public class Room
{
    public string Country { get; private set; }
    public int ID { get; private set; }

    public int Capacity { get; private set; }

    public List<string> Equipment { get; private set; }


    public IEnumerable<string> hello;

    public Room(in string country, in int id, in int capacity, in List<string> equipment)
    => (Country, ID, Capacity, Equipment) = (country, id, capacity, equipment);
}