using System;
using System.Threading;
using System.Collections.Generic;

class MainClass {
    public static void Main (string[] args)
    {
        int count = 0;
        foreach (var result in GetCalculations(100))
        {
            count++;
            Console.WriteLine($"Result of {count} --> {result}");
        }
    }

    public static IEnumerable<int> GetCalculations(int size)
    {
        var random = new Random();

        // var a = new List<int>(size);
        // var b = new List<int>(size);

        // for (int i = 0; i < size; i++)
        // {
        //     a.Add(random.Next(100, 1000));
        //     b.Add(random.Next(100, 1000));
        // }

        for (int i = 0; i < size; i++)
        {
            Thread.Sleep(50);
            yield return random.Next(100, 1000) * random.Next(100, 1000);
        }
    }  
}