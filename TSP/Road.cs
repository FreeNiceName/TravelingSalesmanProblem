namespace TSP
{
    public class Road
    {
        public Location From { get; }
        public Location To { get; }
        public IMetric Metric { private get; set; }

        public Road(Location from, Location to, IMetric metric)
        {
            From = from;
            To = to;
            Metric = metric;
        }

        public float Distance()
        {
            return Metric.Distance(From, To);
        }
    }
}
