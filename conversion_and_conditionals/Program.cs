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
    }
}