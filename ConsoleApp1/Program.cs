using System;
/// <summary>
/// создать расширяющий метод для целочисленного массива, который сортирует элементы массива по возрастанию.
/// </summary>
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main()
        {
            int[] arr = { 5, -20, 4, 3,10, 2, 1 };
            arr.Print();
            arr.Sort();
            arr.Print();

            Console.ReadKey();
        }
    }

    static class ExtenshionInt
    {
        public static int[] Sort(this int[] array)
        {
            int f;
            int temp;
            for (int i = 1; i < array.Length; i++)
            {
                f = 0;
                for (int j = 0; j < array.Length-i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                        f = 1;
                    }
                }
                if (f == 0) break;

            }
            return array;
        }
        public static void Print(this int[] arr)
        {
            foreach (int item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }

}
