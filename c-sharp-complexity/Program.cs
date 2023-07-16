using System.Diagnostics;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
       

        int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        searchForElement(arr,8);

        Console.WriteLine("with using BinarySearch:");

        Console.WriteLine(BinarySearchIterative(arr,8));
    }

    static  void searchForElement(int[] arr, int target)
    {
        // Starting the Stopwatch
        var watch = Stopwatch.StartNew();
        for (int i = 0; i < arr.GetLength(0); i++)
        {

           
            

                if (arr[i] == target)
                {
                Console.WriteLine($"the element is in {i}") ;
                }



            }
        watch.Stop();
        Console.WriteLine($"The Execution time of the program is {watch.ElapsedMilliseconds}ms");
        

    }
    static (int,float ) BinarySearchIterative(int[] arr, int target)
    {
        int left = 0;
        int right = arr.Length - 1;
        var watch = Stopwatch.StartNew();
        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (arr[mid] == target)
               
                return (mid,watch.ElapsedMilliseconds);
            
            if (arr[mid] < target)
                left = mid + 1;
            else
                right = mid - 1;
        }
        watch.Stop();

        return (-1, -1); // Element not found
       
    }


}





