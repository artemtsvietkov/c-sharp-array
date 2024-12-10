internal class Program
{
    private static void Main(string[] args)
    {
        // Uppgift 1 
        // int[] myArray = new int[5];

        // Console.WriteLine("Write 5 numbers to array");
        // for (int i = 0; i < 5; i++)
        // {
        //     Console.Write($"Enter number {i + 1}: ");
        //     myArray[i] = int.Parse(Console.ReadLine());
        // }

        // for (int i = 4; i >= 0; i--)
        // {
        //     Console.WriteLine(myArray[i]);
        // }

        // Uppgift 2
        // int[] array1 = { 5, 10, 15, 20, 25 };
        // int[] array2 = { 1, 2, 3, 4, 5 };
        // int[] array3 = { 8, 12, 16, 20, 24, 28 };

        // int sum;
        // double average;

        // sum = 0;
        // for (int i = 0; i < array1.Length; i++)
        // {
        //     sum += array1[i];
        // }
        // average = (double)sum / array1.Length;
        // Console.WriteLine($"Average of array1: {average}");

        // sum = 0;
        // for (int i = 0; i < array2.Length; i++)
        // {
        //     sum += array2[i];
        // }
        // average = (double)sum / array2.Length;
        // Console.WriteLine($"Average of array2: {average}");

        // sum = 0;
        // for (int i = 0; i < array3.Length; i++)
        // {
        //     sum += array3[i];
        // }
        // average = (double)sum / array3.Length;
        // Console.WriteLine($"Average of array3: {average}");

        // Uppgift 3
       
        // int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        
        
        // List<int> evenNumbers = new List<int>();
        // List<int> oddNumbers = new List<int>();
        
        
        // foreach (int number in numbers)
        // {
        //     if (number % 2 == 0)
        //     {
        //         evenNumbers.Add(number); 
        //     }
        //     else
        //     {
        //         oddNumbers.Add(number);
        //     }
        // }
        
       
        // Console.WriteLine("Jämna tal:");
        // foreach (int even in evenNumbers)
        // {
        //     Console.WriteLine(even);
        // }
        
        // Console.WriteLine("\nUdda tal:");
        // foreach (int odd in oddNumbers)
        // {
        //     Console.WriteLine(odd);
        // }
        // Uppgift 4

        
        
        // int[] array = { 10, 20, 4, 45, 99 };
        // int secondLargest = FindSecondLargest(array);
        
        // Console.WriteLine("Det näst största talet är: " + secondLargest);
        

        // static int FindSecondLargest(int[] array)
        // {
        // int largest = int.MinValue;
        // int secondLargest = int.MinValue;

        // foreach (int num in array)
        // {
        //     if (num > largest)
        //     {
        //         secondLargest = largest;
        //         largest = num;
        //     }
        //     else if (num > secondLargest && num != largest)
        //     {
        //         secondLargest = num;
        //     }
        // }

        //     return secondLargest;
        // }

        int[] array = { 64, 34, 25, 12, 22, 11, 90 };

        Console.WriteLine("Före sortering:");
        PrintArray(array);

        BubbleSort(array);

        Console.WriteLine("Efter sortering:");
        PrintArray(array);
    

    // Funktion för att skriva ut en array
    static void PrintArray(int[] array)
    {
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }

    // Bubble Sort-algoritm
        static void BubbleSort(int[] array)
        {
            int n = array.Length;
            
            // Loop för att gå igenom hela arrayen
            for (int i = 0; i < n - 1; i++)
            {
                // Yttre loop gör flera pass genom arrayen
                for (int j = 0; j < n - i - 1; j++)
                {
                    // Om elementet är större än nästa, byt plats
                    if (array[j] > array[j + 1])
                    {
                        // Byta plats mellan array[j] och array[j + 1]
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }

    }
}

    