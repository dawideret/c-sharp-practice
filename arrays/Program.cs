class Arrays
{
    public static void Main()
    {
        // Arrays
        int[] george_grades = { 5, 2, 6, 9, 9, 4, 6 };
        char[] bobs_grades = { 'A', 'A', 'F', 'B' };

        for (int i = 0; i < george_grades.Length; i++)
        {
            Console.Out.WriteLine(george_grades[i]);
        }

        // Multidimensional Arrays
        int[,] two_dimensions = new int[10,10];

        for (int x = 0; x < two_dimensions.Length; x++)
        {
            for (int y = 0; y < two_dimensions.GetLength(x); y++)
            {

            }
        }
    }
}