namespace TSP
{
    public class Location
    {
        public string Name { get; set; }
        public float X { get; set; }
        public float Y { get; set; }

        public Location(string name, float x, float y)
        {
            Name = name;
            X = x;
            Y = y;
        }
    }
}
