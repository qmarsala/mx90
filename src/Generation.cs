namespace mx90
{
    public class Generation
    {
        public bool[] Cells { get; private set; }
        public int Size => Cells.Length;

        private Generation(bool[] cells)
        {
            Cells = cells;
        }

        private static bool[] BuildInitialGeneration(int size)
        {
            var generation = new bool[size];
            generation[0] = true;
            for (var i = 1; i < generation.Length; i++)
            {
                generation[i] = false;
            }
            return generation;
        }

        public static Generation Create(int size)
        {
            var cells = BuildInitialGeneration(size);
            return new Generation(cells);
        }

        public Generation Next(Rule rule)
        {
            return new Generation(new bool[Size]);
        }
    }
}
