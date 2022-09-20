namespace PAA_Lab1
{
    public class MergeSorter : Sorter
    {
        public override string Name => "Merge";

        public override void Sort(int[] array)
        {
            Sort(array, 0, array.Length - 1);
        }

        private void Sort(int[] array, int low, int high)
        {
            if (low < high)
            {
                int middle = (low + high) / 2;
                Sort(array, low, middle);
                Sort(array, middle + 1, high);
                Merge(array, low, middle, high);
            }
        }

        private void Merge(int[] array, int low, int middle, int high)
        {
            int left = low;
            int right = middle + 1;
            var tempArray = new int[high - low + 1];
            int index = 0;

            while ((left <= middle) && (right <= high))
            {
                _comparisonsCount++;
                if (array[left] < array[right])
                {
                    tempArray[index] = array[left];
                    left++;
                }
                else
                {
                    tempArray[index] = array[right];
                    right++;
                }

                index++;
            }

            for (int i = left; i <= middle; i++)
            {
                tempArray[index] = array[i];
                index++;
            }

            for (int i = right; i <= high; i++)
            {
                tempArray[index] = array[i];
                index++;
            }

            for (int i = 0; i < tempArray.Length; i++)
            {
                _swapsCount++;
                array[low + i] = tempArray[i];
            }
        }
    }
}
