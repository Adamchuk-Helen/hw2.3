using System;

namespace HW2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Перерозташувати елементи у масиві(відємні, невідємні) у порядку їх слідування. 
            //Для масиву : 1  2 - 4 - 55 - 7 10 100
            //Повинні отримати змінений масив: -4 - 55 - 7  1 2 10 100
            //Використати FindAll(), CopyTo().

            int[] arr = { 1,  2, - 4, - 55, - 7, 10, 100 };
            
            int[] arr2 = Array.FindAll(arr,  j=> j < 0);
            int[] arr3 = Array.FindAll(arr, j => j > 0);
            int[] arr4 = new int[arr.Length];
            arr2.CopyTo(arr4, 0);
            arr3.CopyTo(arr4, arr2.Length);

            foreach (int i in arr4)
            {
                Console.WriteLine(i);
            }
        }  
    }
}
