using System;

namespace TSP
{
    public class CityBlockDistance: IMetric
    {
        public float Distance(Location a, Location b)
        {
            return Math.Abs(a.X - b.X) + Math.Abs(a.Y - b.Y);
        }
    }
}
