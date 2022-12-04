using NoStringEvaluating.Models.Values;
using NoStringEvaluating;

namespace BeesAlg
{
    internal class BeesAlgorithm
    {
        public Parameters AlgorithmParameters { get; private set; }

        public List<double[]> Places { get; private set; } // places with honey, function arguments meanings

        public BeesAlgorithm(Parameters algorithmParameters)
        {
            AlgorithmParameters = algorithmParameters;
            Places = FindKRandomPlaces(algorithmParameters.LowerLimitVariables, 
                algorithmParameters.UpperLimitVariables, algorithmParameters.Variables.Length,
                algorithmParameters.ResearchPointsAmount);
        }

        public double[] Execute()
        {
            int iterationNumber = 0;
            SortPlaces();
            double[] lastBestPlace = new double [Places[0].Length];
            double[] bestPlace = Places[0];
             
            while(((iterationNumber < AlgorithmParameters.IterationsAmount 
                && AlgorithmParameters.UseIterationsAmount) || (!AlgorithmParameters.UseIterationsAmount)) &&
                (!AlgorithmParameters.UseStopDelta || (AlgorithmParameters.UseStopDelta && 
                (GetFitness(lastBestPlace) - GetFitness(bestPlace) >= AlgorithmParameters.StopDelta))))
            {
                lastBestPlace = bestPlace;
                // bees search
                for (int i = 0; i < AlgorithmParameters.BeesResearchPointsAmount; i++)
                {
                    int beesAmount = 0;
                    if (i > AlgorithmParameters.ElitePlacesAmount)
                        beesAmount = AlgorithmParameters.BeesAmountToResearchElitePlaces;
                    else
                        beesAmount = AlgorithmParameters.BeesAmountToResearchUsualPlaces;
                    for (int j = 0; j < beesAmount; j++)
                    {
                        double[] neighborhoodPlace = RandomPlaceInNeighborhood(Places[i], 
                            AlgorithmParameters.SearchNeighborhood);
                        if (GetFitness(neighborhoodPlace) < GetFitness(Places[i]))
                            Places[i] = neighborhoodPlace;
                    }
                }

                // random search
                for (int i = AlgorithmParameters.BeesResearchPointsAmount; 
                    i < AlgorithmParameters.ResearchPointsAmount; i++)
                    Places[i] = FindRandomPlace(AlgorithmParameters.LowerLimitVariables,
                        AlgorithmParameters.UpperLimitVariables, AlgorithmParameters.Variables.Length);

                iterationNumber++;
                SortPlaces();
                bestPlace = Places[0];
            }
            return bestPlace;
        }

        void SortPlaces()
        {
            var places = Places.ToArray();
            Array.Sort(GetFitnesses(), places);
            Places = places.ToList();
        }

        double[] GetFitnesses()
        {
            double[] fitnesses = new double[AlgorithmParameters.ResearchPointsAmount];
            var vars = new Dictionary<string, EvaluatorValue>();
            NoStringEvaluator evaluator = NoStringEvaluator.CreateFacade().Evaluator;
            for (int j = 0; j < AlgorithmParameters.ResearchPointsAmount; j++)
            {
                vars.Clear();
                for (int i = 0; i < AlgorithmParameters.Variables.Length; i++)
                {
                    var value = Places[j][i];
                    vars.Add(AlgorithmParameters.Variables[i], value);
                }
                fitnesses[j] = evaluator.CalcNumber(AlgorithmParameters.Function, vars);
            }
            return fitnesses;
        }

        double GetFitness(double[] point)
        {
            var vars = new Dictionary<string, EvaluatorValue>();
            NoStringEvaluator evaluator = NoStringEvaluator.CreateFacade().Evaluator;

            for (int i = 0; i < point.Length; i++)
            {
                var value = point[i];
                vars.Add(AlgorithmParameters.Variables[i], value);
            }

            return evaluator.CalcNumber(AlgorithmParameters.Function, vars);
        }

        static List<double[]> FindKRandomPlaces(double low, double high, int pointDimension, 
            int amountOfPlaces)
        {
            List<double[]> places = new List<double[]>();
            for (int i = 0; i < amountOfPlaces; i++)
                places.Add(FindRandomPlace(low, high, pointDimension));
            return places;
        }

        static double[] RandomPlaceInNeighborhood(double[] place, double delta)
        {
            double[] neighborhoodPlace = new double[place.Length];
            var rand = new Random();
            for (int i = 0; i < place.Length; i++)
                neighborhoodPlace[i] = rand.NextDouble() * (2 * delta) + (place[i] - delta);
            return neighborhoodPlace;
        }

        static double[] FindRandomPlace(double low, double high, int pointDimension)
        {
            double[] answer = new double[pointDimension];
            var rand = new Random();
            for (int i = 0; i < pointDimension; i++)
                answer[i] = rand.NextDouble() * (high - low) + low;
            return answer;
        }
    }
}
