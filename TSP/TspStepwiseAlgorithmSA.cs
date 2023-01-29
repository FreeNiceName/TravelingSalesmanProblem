using System;

namespace TSP
{
    public class TspStepwiseAlgorithmSA : TspStepwiseAlgorithm
    {
        private Random _rand;

        public int MaxIterations { get; set; }
        public double InitialTemperature { get; set; }
        public double EndTemperature { get; set; }
        public double TemperatureStep { get; set; }
        public double CurrentTemperature { get; private set; }
        public int CurrentIteration { get; private set; } = 0;

        public TspStepwiseAlgorithmSA()
        {
            _rand = new Random();

            MaxIterations = 1000000;
            InitialTemperature = CurrentTemperature = 100;
            EndTemperature = 0;
            TemperatureStep = 0.1;
        }

        public override bool MoveNext()
        {
            if (CurrentTemperature < EndTemperature)
                return false;

            if (CurrentIteration >= MaxIterations)
                return false;

            var nextRouteIndexes = NextRouteIndexes(CurrentRouteIndexes);
            var nextRouteLength = GetRouteLength(nextRouteIndexes);
            if (nextRouteLength < CurrentRouteLength)
                UpdateRoute(nextRouteIndexes, nextRouteLength);
            else
            {
                var p = GetTransitionProbability(nextRouteLength - CurrentRouteLength);
                if (IsTransition(p))
                    UpdateRoute(nextRouteIndexes, nextRouteLength);
            }

            CurrentIteration++;
            DecreaseTemperature();

            return true;
        }

        private int[] NextRouteIndexes(int[] currentRouteIndexes)
        {
            var next = (int[])currentRouteIndexes.Clone();

            var a = _rand.Next(1, next.Length);
            var b = _rand.Next(1, next.Length);

            var temp = next[a];
            next[a] = next[b];
            next[b] = temp;

            return next;
        }

        private double GetTransitionProbability(double LengthsDelta)
        {
            return Math.Exp(-(LengthsDelta / CurrentTemperature));
        }

        private bool IsTransition(double probability)
        {
            var value = _rand.NextDouble();
            return value <= probability;
        }

        private void DecreaseTemperature()
        {
            CurrentTemperature = InitialTemperature - CurrentIteration * TemperatureStep;
        }

        private void UpdateRoute(int[] routeIndexes, double routeLength)
        {
            CurrentRouteIndexes = routeIndexes;
            CurrentRouteLength = routeLength;
            CurrentRoute = CreateRouteFromIndexes(routeIndexes);
        }
    }
}
