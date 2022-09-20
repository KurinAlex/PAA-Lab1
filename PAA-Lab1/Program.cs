namespace PAA_Lab1
{
    public class Program
    {
        static readonly ArrayGenerationOptions[] generationOptions = Enum.GetValues<ArrayGenerationOptions>();
        static readonly int[] sizes = { 1000, 10000, 100000 };
        static readonly Sorter[] sorters = { new BubbleSorter(), new MergeSorter(), new RadixSorter() };

        static void OutputDivider()
        {
            Console.WriteLine(new string('-', 90));
        }

        static bool IsSorted(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i - 1] > array[i])
                {
                    return false;
                }
            }
            return true;
        }

        static int[] GenerateArray(int size, ArrayGenerationOptions options)
        {
            Random rand = new();
            int[] array = new int[size];

            for (int i = 0; i < size; i++)
            {
                array[i] = rand.Next(1, 1000);
            }

            if (options != ArrayGenerationOptions.Random)
            {
                Array.Sort(array);
                if (options == ArrayGenerationOptions.Descending)
                {
                    Array.Reverse(array);
                }
            }

            return array;
        }

        static void Main(string[] args)
        {
            foreach (var options in generationOptions)
            {
                Console.WriteLine($"\t\t\t\t{options} generated array");
                OutputDivider();

                foreach (int size in sizes)
                {
                    int[] array = GenerateArray(size, options);
                    int[] arrayToSort = new int[size];

                    Console.WriteLine($"\t\t\t\tArray of size {size}");
                    OutputDivider();

                    foreach (Sorter sorter in sorters)
                    {
                        array.CopyTo(arrayToSort, 0);
                        Console.WriteLine($"{sorter.Name} sort:");

                        var result = sorter.GetSortingResult(arrayToSort);

                        Console.WriteLine($"> Comparisons: {result.Comparisons}");
                        Console.WriteLine($"> Swaps: {result.Swaps}");
                        Console.WriteLine($"> Time: {result.Time} ms");
                        OutputDivider();
                    }
                }
            }
        }
    }
}
