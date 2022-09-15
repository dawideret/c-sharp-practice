using System;

public class hello_world
{
    public static void Main()
    {
        List<string> words = new();

        words.Add("Apple");
        words.Add("Watch");
        words.Add("Is");
        words.Add("Too");
        words.Add("Expensive");

        string[] words_array = new string[] { "Change", "My", "Mind" };

        words.AddRange(words_array);
        words.Remove("Too");
        words.RemoveAt(1);

        for (int i = 0; i < words.Count; i++)
        {
            Console.WriteLine(words[i]);
        }
    }
}