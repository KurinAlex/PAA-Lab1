namespace PAA_Lab1
{
    public class RadixSorter : Sorter
    {
        public override string Name => "Radix";

        public override void Sort(int[] array)
        {
            int max = array.Max();
            for (int exp = 1; max / exp > 0; exp *= _base)
            {
                CountSort(array, exp);
            }
        }

        private void CountSort(int[] array, int exp)
        {
            int n = array.Length;
            int[] output = new int[n];
            int[] count = new int[_base];

            for (int i = 0; i < n; i++)
            {
                count[array[i] / exp % _base]++;
            }

            for (int i = 1; i < _base; i++)
            {
                count[i] += count[i - 1];
            }

            for (int i = n - 1; i >= 0; i--)
            {
                output[count[array[i] / exp % _base] - 1] = array[i];
                count[array[i] / exp % _base]--;
            }

            for (int i = 0; i < n; i++)
            {
                _swapsCount++;
                array[i] = output[i];
            }
        }

        private const int _base = 10;
    }
}
