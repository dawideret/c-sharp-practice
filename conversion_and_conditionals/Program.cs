public class conv_n_cond
{
    public static void Main()
    {
        // Conversion
        int x = 100;
        float y = 200f;
        double z = 300;

        string combined = Convert.ToString(x) + Convert.ToString(y) + Convert.ToString(z);
        Console.WriteLine(combined);
        float a = float.Parse(combined) / 123456.7898765321f;
        Console.WriteLine(a);

        // Conditionals (Comparison Symbols: <, >, <=, >=, ==, !=, ||, &&, !value)
        double pi = 3.14;
        double circumference = 5;
        double diameter = circumference / pi;

        if (diameter == 1.592356687898089) {
            Console.WriteLine("You're right... " + diameter);
        } else {
            Console.WriteLine("You're wrong... " + diameter);
        }
    }
}