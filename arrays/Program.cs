class Arrays
{
    public static void Main()
    {
        // Arrays
        int[] george_grades = { 5, 2, 6, 9, 9, 4, 6 };
        char[] bobs_grades = { 'A', 'A', 'F', 'B' };

        for (int i = 0; i < george_grades.Length; i++)
        {
            Console.WriteLine(george_grades[i]);
        }

        // Multidimensional Arrays
        Console.WriteLine(" ----------------------- ");
        int[,] two_dimensions = new int[30,30];

        for (int x = 0; x < two_dimensions.GetLength(0); x++)
        {
            for (int y = 0; y < two_dimensions.GetLength(1); y++)
            {
                two_dimensions[x, y] = (x + 1) * y ^ 2;
                Console.WriteLine(two_dimensions[x, y]);
            }
        }
    }   
}