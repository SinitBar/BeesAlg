namespace BeesAlg
{
    internal class Parameters
    {
        public double LowerLimitVariables { get; private set; }
        public double UpperLimitVariables { get; private set; }
        public string Function { get; private set; } // objective function
        public string[] Variables { get; private set; } // variables used in objective function
        public int ResearchPointsAmount { get; private set; } // s
        public int BeesResearchPointsAmount { get; private set; } // m
        public int ElitePlacesAmount { get; private set; } // e
        public int BeesAmountToResearchElitePlaces { get; private set; } // s_e
        public int BeesAmountToResearchUsualPlaces { get; private set; } // s_p
        public double SearchNeighborhood { get; private set; } // delta
        public int IterationsAmount { get; private set; } 
        public double StopDelta { get; private set; }
        public bool UseIterationsAmount { get; private set; }
        public bool UseStopDelta { get; private set; }

    public Parameters(double lowerLimitVariables, double upperLimitVariables, string function, 
            string[] variables, int researchPointsAmount, int beesResearchPointsAmount, 
            int elitePlacesAmount, int beesAmountToResearchElitePlaces, int beesAmountToResearchUsualPlaces, 
            double searchNeighborhood, int iterationsAmount, double stopDelta,
            bool useIterationsAmount = true, bool useStopDelta = false)
        {
            LowerLimitVariables = lowerLimitVariables;
            UpperLimitVariables = upperLimitVariables;
            Function = function;
            Variables = variables;
            ResearchPointsAmount = researchPointsAmount;
            BeesResearchPointsAmount = beesResearchPointsAmount;
            ElitePlacesAmount = elitePlacesAmount;
            BeesAmountToResearchElitePlaces = beesAmountToResearchElitePlaces;
            BeesAmountToResearchUsualPlaces = beesAmountToResearchUsualPlaces;
            SearchNeighborhood = searchNeighborhood;
            IterationsAmount = iterationsAmount;
            StopDelta = stopDelta;
            UseIterationsAmount = useIterationsAmount;
            UseStopDelta = useStopDelta;
        }
    }
}
