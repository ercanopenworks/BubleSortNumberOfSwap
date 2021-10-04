using System;
using System.Collections.Generic;
using System.Linq;

namespace BubleSortNumberOfSwap
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();
            // Track number of elements swapped during a single array traversal
            int numberOfSwaps = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    // Swap adjacent elements if they are in decreasing order
                    int temp = 0;
                    if (a[j] > a[j + 1])
                    {
                        temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                        //swap(a[j], a[j + 1]);
                        numberOfSwaps++;
                    }
                }

                // If no elements were swapped during a traversal, array is sorted
                if (numberOfSwaps == 0)
                {
                    break;
                }
            }

            if (numberOfSwaps == 0)
            {
                Console.WriteLine("Array is sorted in 0 swaps.");
            }
            else
            {
                Console.WriteLine($"Array is sorted in {numberOfSwaps} swaps.");
            }

            Console.WriteLine($"First Element: {a[0]}");
            Console.WriteLine($"Last  Element: {a[a.Count - 1]}");

        }

    }
}
