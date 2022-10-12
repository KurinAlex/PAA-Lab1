namespace PAA_Lab1
{
    public class Program
    {
        const int minValue = 0;
        const int maxValue = 1000;

        static readonly ArrayGenerationOptions[] generationOptions = Enum.GetValues<ArrayGenerationOptions>();
        static readonly int[] sizes = { 1000, 10000, 100000 };
        static readonly Sorter[] sorters = { new BubbleSorter(), new MergeSorter(), new RadixSorter() };

        static void WriteDivider()
        {
            Console.WriteLine(new string('-', 90));
        }

        static void Main(string[] args)
        {
            foreach (var options in generationOptions)
            {
                Console.WriteLine($"\t\t\t\t{options} generated array");
                WriteDivider();

                foreach (int size in sizes)
                {
                    int[] array = Generator.GenerateArray(size, minValue, maxValue, options);
                    int[] arrayToSort = new int[size];

                    Console.WriteLine($"\t\t\t\tArray of size {size}");
                    WriteDivider();

                    foreach (Sorter sorter in sorters)
                    {
                        array.CopyTo(arrayToSort, 0);
                        Console.WriteLine($"{sorter.Name} sort:");

                        var result = sorter.GetSortingResult(arrayToSort);

                        Console.WriteLine($"> Comparisons: {result.Comparisons}");
                        Console.WriteLine($"> Copies: {result.Copies}");
                        Console.WriteLine($"> Time: {result.Time} ms");
                        WriteDivider();
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
