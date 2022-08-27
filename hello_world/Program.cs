using System;
using System.Security.Cryptography.X509Certificates;

public enum StudentIDs
{
    Chris = 15213,
    John = 21214,
    Bartley = 35424,
    Mabel = 46316,
    Courtney = 54216,
}

public class hello_world
{
    public static void Main()
    {
        Console.WriteLine("Hello World");
        Console.WriteLine(Console.ReadLine());

        int a = 1;
        float b = 2f;
        bool c = true;
        string d = "Hello";
        char e = 'e';
        double f = 1.75;

        var g = 1;
        var h = "string";
        var i = a + g; // 'g' and 'i' will be integers, while 'h' will be a string

        StudentIDs searchedStudent = StudentIDs.Mabel;

        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);
        Console.WriteLine(d);
        Console.WriteLine(e);
        Console.WriteLine(f);
        Console.WriteLine(g);
        Console.WriteLine(h);
        Console.WriteLine(i);
    }
}