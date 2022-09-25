using System;

class GFG
{
    static void bubbleSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
            for (int j = 0; j < n - i - 1; j++)
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
        int[] arr = { 79, 41, 20, 76, 29, 5, 21, 70, 90, 15 };
        bubbleSort(arr);
        Console.WriteLine("Dizinin sıralanmış hali :");
        printArray(arr);
    }
}