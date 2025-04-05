public class Room
{
    public string Country { get; set; }
    public int ID { get; set; }

    public int Capacity { get; set; }

    public List<string> Equipment { get; set; }

    public Room(in string country, in int id, in int capacity, in List<string> equipment)
    => (Country, ID, Capacity, Equipment) = (country, id, capacity, equipment);

    public Room()
    {
    }

    public string EquipmentToString()
    {
        string equipment = "";

        // foreach (string equipmentTmp in Equipment)
        // {
        //     if (Equipment.Count())
        // }
        for (int i = 0; i < Equipment.Count() - 1; i++)
        {
            equipment += Equipment.ElementAt(i) + ", ";
        }
        equipment += Equipment.Last();
        
        return equipment;
    }
}