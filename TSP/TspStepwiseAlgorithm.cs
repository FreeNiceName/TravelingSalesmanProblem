using System;
using System.Collections.Generic;
using System.Linq;

namespace TSP
{
    public abstract class TspStepwiseAlgorithm
    {
        protected float[,] Distances { get; set; }
        protected int[] CurrentRouteIndexes { get; set; }

        public IList<Location> Locations { get; set; }
        public IEnumerable<Road> Roads { get; set; }

        public double CurrentRouteLength { get; protected set; }
        public IList<Location> CurrentRoute { get; protected set; }

        public abstract bool MoveNext();

        public void Init(Location start)
        {
            if (start == null)
                throw new ArgumentNullException("start");

            if (!Locations.Contains(start))
                throw new ArgumentException("There is no start location in locations list");

            FillDistancesMatrix();

            CurrentRouteIndexes = new int[Locations.Count];
            for (var i = 0; i < CurrentRouteIndexes.Length; ++i)
            {
                CurrentRouteIndexes[i] = i;
                if (Locations[i] == start)
                {
                    CurrentRouteIndexes[0] = i;
                    CurrentRouteIndexes[i] = 0;
                }
            }

            CurrentRouteLength = GetRouteLength(CurrentRouteIndexes);
            CurrentRoute = CreateRouteFromIndexes(CurrentRouteIndexes);
        }
        protected void FillDistancesMatrix()
        {
            if (Locations.Count == 0)
                throw new InvalidOperationException("No locations entered");

            if (Roads?.Any() != true)
                throw new InvalidOperationException("No roads entered");

            Distances = new float[Locations.Count, Locations.Count];
            Distances.Fill(float.PositiveInfinity);

            foreach (var road in Roads)
            {
                var from = road.From;
                var to = road.To;

                if (!Locations.Contains(from)
                    || !Locations.Contains(to))
                    continue;

                var fromIndex = Locations.IndexOf(from);
                var toIndex = Locations.IndexOf(to);

                var distance = road.Distance();

                Distances[fromIndex, toIndex] = Math.Min(Distances[fromIndex, toIndex], distance);
            }
        }

        protected double GetRouteLength(int[] indexes)
        {
            double length = Distances[indexes[indexes.Length - 1], indexes[0]];
            for (var i = 0; i < indexes.Length - 1; ++i)
                length += Distances[indexes[i], indexes[i + 1]];

            return length;
        }

        protected IList<Location> CreateRouteFromIndexes(int[] indexes)
        {
            var route = new List<Location>(Locations.Count);
            for (var i = 0; i < Locations.Count; ++i)
                route.Add(Locations[indexes[i]]);
            return route;
        }
    }
}
