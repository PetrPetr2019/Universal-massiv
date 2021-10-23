using System;

namespace Universal_massiv
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = {1, 2, 3};
            Resize<int>(ref myArray, 4);
        }


        static  void Resize<T>(ref int[] array, int newSize)
        {
           int[] newArray = new int[newSize];
           for (int i = 0; i < array.Length && i < newArray.Length; i++)
           {
               newArray[i] = array[i];
           }

           array = newArray;
        }
    }
}
