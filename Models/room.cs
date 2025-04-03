public class Room
{
    public string Country { get; private set; }
    public int ID { get; private set; }

    public int Capacity { get; private set; }

    public List<string> Equipment { get; private set; }

    public Room(in string country, in int id, in int capacity, in List<string> equipment)
    => (Country, ID, Capacity, Equipment) = (country, id, capacity, equipment);

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