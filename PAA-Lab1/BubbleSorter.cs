namespace PAA_Lab1
{
    public class BubbleSorter : Sorter
    {
        public override string Name => "Bubble";

        public override void Sort(int[] array)
        {
            int n = array.Length;
            bool changed;
            do
            {
                changed = false;
                for (int i = 1; i < n; i++)
                {
                    _comparisonsCount++;
                    if (array[i - 1] > array[i])
                    {
                        _copiesCount += 3;
                        (array[i], array[i - 1]) = (array[i - 1], array[i]);
                        changed = true;
                    }
                }
                n--;
            } while (changed);
        }
    }
}
