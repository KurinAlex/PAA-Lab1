using System.Diagnostics;

namespace PAA_Lab1
{
    public abstract class Sorter
    {
        public abstract string Name { get; }

        public SortingResult GetSortingResult(int[] array)
        {
            var stopwatch = Stopwatch.StartNew();

            _swapsCount = 0;
            _comparisonsCount = 0;
            Sort(array);

            stopwatch.Stop();

            return new SortingResult(_swapsCount, _comparisonsCount, stopwatch.Elapsed.TotalMilliseconds);
        }

        public abstract void Sort(int[] array);

        protected long _swapsCount;
        protected long _comparisonsCount;
    }
}
