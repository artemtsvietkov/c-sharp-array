using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("=== Välj uppgift att köra ===");
        Console.WriteLine("1 - Omvänd ordning (Array)");
        Console.WriteLine("2 - Medelvärde av fält");
        Console.WriteLine("3 - Dela upp fält i listor (jämna och udda)");
        Console.WriteLine("4 - Multiplikationstabell");
        Console.WriteLine("5 - Näst största talet i fält");
        Console.WriteLine("6 - Sortera lista/array");
        Console.Write("Ditt val: ");
        string val = Console.ReadLine();

        switch (val)
        {
            case "1": Uppgift1(); break;
            case "2": Uppgift2(); break;
            case "3": Uppgift3(); break;
            case "4": Uppgift4(); break;
            case "5": Uppgift5(); break;
            case "6": Uppgift6(); break;
            default: Console.WriteLine("Ogiltigt val."); break;
        }
    }

    // Uppgift 1 
    static void Uppgift1()
    {
        Console.WriteLine("=== Uppgift 1: Omvänd ordning ===");
        int[] numbers = new int[5];
        Console.WriteLine("Mata in 5 tal:");
        for (int i = 0; i < 5; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Talen i omvänd ordning:");
        Array.Reverse(numbers);
        foreach (var num in numbers)
        {
            Console.WriteLine(num);
        }
    }

    // Uppgift 2
    static void Uppgift2()
    {
        Console.WriteLine("=== Uppgift 2: Medelvärde ===");
        int[] array1 = { 1, 2, 3, 4, 5 };
        int[] array2 = { 10, 20, 30, 40, 50 };
        int[] array3 = { 100, 200, 300, 400, 500 };

        Console.WriteLine($"Medelvärde av array1: {BeräknaMedelvärde(array1)}");
        Console.WriteLine($"Medelvärde av array2: {BeräknaMedelvärde(array2)}");
        Console.WriteLine($"Medelvärde av array3: {BeräknaMedelvärde(array3)}");
    }

    static double BeräknaMedelvärde(int[] array)
    {
        return array.Average();
    }

    // Uppgift 3
    static void Uppgift3()
    {
        Console.WriteLine("=== Uppgift 3: Jämna och udda listor ===");
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        List<int> evenNumbers = new List<int>();
        List<int> oddNumbers = new List<int>();

        foreach (var num in numbers)
        {
            if (num % 2 == 0)
                evenNumbers.Add(num);
            else
                oddNumbers.Add(num);
        }

        Console.WriteLine("Jämna tal:");
        foreach (var num in evenNumbers)
        {
            Console.WriteLine(num);
        }

        Console.WriteLine("Udda tal:");
        foreach (var num in oddNumbers)
        {
            Console.WriteLine(num);
        }
    }

    // Uppgift 4 
    static void Uppgift4()
    {
        Console.WriteLine("=== Uppgift 4: Multiplikationstabell ===");
        Console.Write("Mata in antalet rader: ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("Mata in antalet kolumner: ");
        int columns = int.Parse(Console.ReadLine());

        for (int i = 1; i <= rows; i++)
        {
            for (int j = 1; j <= columns; j++)
            {
                Console.Write($"{i * j}\t");
            }
            Console.WriteLine();
        }
    }

    // Uppgift 5 
    static void Uppgift5()
    {
        Console.WriteLine("=== Uppgift 5: Näst största talet ===");
        int[] numbers = { 10, 30, 50, 20, 40 };
        Array.Sort(numbers);
        Console.WriteLine($"Det näst största talet är: {numbers[numbers.Length - 2]}");
    }

    // Uppgift 6 
    static void Uppgift6()
    {
        Console.WriteLine("=== Uppgift 6: Sortera lista/array ===");
        int[] numbers = { 5, 1, 9, 3, 7, 6, 8 };
        Console.WriteLine("Innan sortering:");
        foreach (var num in numbers)
        {
            Console.WriteLine(num);
        }

        for (int i = 0; i < numbers.Length - 1; i++)
        {
            for (int j = 0; j < numbers.Length - 1 - i; j++)
            {
                if (numbers[j] > numbers[j + 1])
                {
                    int temp = numbers[j];
                    numbers[j] = numbers[j + 1];
                    numbers[j + 1] = temp;
                }
            }
        }

        Console.WriteLine("Efter sortering:");
        foreach (var num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}
