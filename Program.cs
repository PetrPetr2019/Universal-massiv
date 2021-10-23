using System;

namespace Universal_massiv
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] myArray = {1, 2, 3};
            string[] myString = new[] { "Test", "Hello", "Tomas"};
            
            Resize<string>(ref myString, 1);
        }


        static  void Resize<T>(ref T[] array, int newSize)
        {
           T[] newArray = new T[newSize];

           for (var i = 0; i < array.Length && i < newArray.Length; i++)
           {
               newArray[i] = array[i];
           }

           array = newArray;
        }
    }
}
