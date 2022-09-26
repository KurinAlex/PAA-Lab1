namespace PAA_Lab1
{
    public static class Generator
    {
        public static int[] GenerateArray(int size, int min, int max, ArrayGenerationOptions options)
        {
            Random rand = new();
            int[] array = new int[size];

            for (int i = 0; i < size; i++)
            {
                array[i] = rand.Next(min, max);
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
    }
}
