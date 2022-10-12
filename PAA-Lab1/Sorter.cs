using System.Diagnostics;

namespace PAA_Lab1
{
    public abstract class Sorter
    {
        public abstract string Name { get; }

        public SortingResult GetSortingResult(int[] array)
        {
            var stopwatch = Stopwatch.StartNew();

            _comparisonsCount = 0;
            _copiesCount = 0;
            Sort(array);

            stopwatch.Stop();

            return new SortingResult(_comparisonsCount, _copiesCount, stopwatch.Elapsed.TotalMilliseconds);
        }

        public abstract void Sort(int[] array);

        protected long _comparisonsCount;
        protected long _copiesCount;
    }
}
