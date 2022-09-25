using System;

namespace Bubble_Alg 
{ 

    class Program 
    {
    static void bubbleSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
            for (int j = 0; j < n-i-1; j++)
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;

                }
    }

    static void printArray(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n; ++i) 
        Console.Write(arr[i] + " ");
        Console.WriteLine();



    }
        
        public static void Main()
    {
        int[] arr = { 34, 76, 31, 8, 87, 12, 45, 68, 94, 14, 5, 98 };
        bubbleSort(arr);
        Console.WriteLine("Dizinin Sıralanmış Hali: ");
        printArray(arr);

    }

    } 
}

