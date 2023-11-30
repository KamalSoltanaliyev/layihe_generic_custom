using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        GenericCustomList<int> customList = new GenericCustomList<int>();

        for (int i = 1; i <= 10; i++)
        {
            customList.Add(i);
        }

        Console.WriteLine($"Count: {customList.Count}");
        Console.WriteLine($"Capacity: {customList.Capacity}");

        // Find methodu
        int foundItem = customList.Find(x => x > 7);
        Console.WriteLine("Find: " + foundItem);
        
        // FindAll methodu
        List<int> foundItems = customList.FindAll(x => x % 2 == 0);
        Console.Write("FindAll even numbers: ");
        foreach (int item in foundItems)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();

        // Contains methodu
        bool containsItem = customList.Contains(5);
        Console.WriteLine("Contains item 5: " + containsItem);

        // Exists methodu
        bool existsItem = customList.Exists(x => x == 14);
        Console.WriteLine("Exists item 14: " + existsItem);

        // Remove methodu
        customList.Remove(3);
        Console.Write("After removing 3: ");
        foreach (int item in customList)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}


class GenericCustomList<T> : List<T>
{
    
}