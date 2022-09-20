namespace PAA_Lab1
{
    public struct SortingResult
    {
        public SortingResult(long swaps, long comparisons, double time)
        {
            Swaps = swaps;
            Comparisons = comparisons;
            Time = time;
        }

        public long Swaps;
        public long Comparisons;
        public double Time;
    }
}
