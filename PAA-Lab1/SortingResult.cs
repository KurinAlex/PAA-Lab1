namespace PAA_Lab1
{
    public struct SortingResult
    {
        public SortingResult(long comparisons, long copies, double time)
        {
            Comparisons = comparisons;
            Copies = copies;
            Time = time;
        }

        public long Comparisons;
        public long Copies;
        public double Time;
    }
}
