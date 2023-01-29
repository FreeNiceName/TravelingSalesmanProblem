namespace TSP
{
    public interface IMetric
    {
        float Distance(Location from, Location to);
    }
}
