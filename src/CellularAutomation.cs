namespace mx90
{
    public class CellularAutomation
    {
        public Generation[] Generations { get; private set; }
        public int Size => Generations.Length;

        private CellularAutomation(Generation[] generations)
        {
            Generations = generations;
        }

        public static CellularAutomation Create(int size)
        {
            var startingGeneration = Generation.Create(size);
            var generations = BuildCellularAutomation(startingGeneration);
            return new CellularAutomation(generations);
        }

        public static CellularAutomation Create(Generation startingGeneration)
        {
            var generations = BuildCellularAutomation(startingGeneration);
            return new CellularAutomation(generations);
        }

        private static Generation[] BuildCellularAutomation(Generation startingGeneration)
        {
            var generations = new Generation[startingGeneration.Size];
            generations[0] = startingGeneration;
            for (var i = 1; i < generations.Length; i++)
            {
                generations[i] = generations[i - 1].Next(null);
            }
            return generations;
        }
    }
}
