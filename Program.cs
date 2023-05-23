

using System;
class Program
{
    static void Main()
    {
        int[] myArray = { 0, 1, 2, 3, 4 };
        Console.WriteLine(myArray[0]);  
        Console.WriteLine(myArray[2]);  
        for (int i = 0; i < myArray.Length; i++)
        {
            Console.WriteLine(myArray[i]);
        }
    }
}