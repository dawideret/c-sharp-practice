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

        // Jagged Arrays
        Console.WriteLine(" ----------------------- ");
        char[][][] gradesMain = new char[2][][];
        gradesMain[0] = new char[2][];
        gradesMain[1] = new char[2][];

        gradesMain[0][0] = new char[2] { 'A', 'B' };
        gradesMain[0][1] = new char[2] { 'C', 'D' };
        gradesMain[1][0] = new char[2] { 'E', 'F' };
        gradesMain[1][1] = new char[2] { 'G', 'H' };

        for (int x = 0; x < gradesMain.Length; x++)
        {
            for (int y = 0; y < gradesMain[x].Length; y++)
            {
                for (int z = 0; z < gradesMain[x][y].Length; z++)
                {
                    Console.WriteLine("Grades Main: " + gradesMain[x][y][z]);
                }
            }
        }
    }   
}