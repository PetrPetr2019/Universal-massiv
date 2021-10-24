using System;
using System.Linq;


namespace Universal_massiv
{
    class Program
    {
        static void Main(string[] args)
        {
            #region show myArray

            ////int[] myArray = {1, 2, 3};
            //string[] myString = { "Test", "Hello", "Tomas"};

            //Resize(ref myString, 1);
            #endregion

            int[] myArray = {1, 4, 6, 2};
            //InnerArray<T>(ref myArray, -5, 0); // // If we specify zero 0 in place 2 , then we will add an element to the beginning of the array
           //AddFirst(ref myArray, -5);
            AddLast(ref myArray,-5 );
            Console.ReadLine();
        }
        #region massiv universal

        //static  void Resize<T>(ref T[] array, int newSize)
        //{
        //   var newArray = new T[newSize];

        //   for (var i = 0; i < array.Length && i < newArray.Length; i++)
        //   {
        //       newArray[i] = array[i];
        //   }

        //   array = newArray;
        //}
        #endregion

        public  static void InnerArray<T>(ref T[] array, T value, int index)
        {
            var myArray = new T[array.Length + 1];
            myArray[index] = value;

            for (var i = 0; i < index; i++)
            {
                myArray[i] = array[i];
            }
            for (var i = index; i < array.Length; i++)
            {
                myArray[i + 1] = array[i];
            }

            array = myArray;
        }
        static  void AddFirst(ref int[] array, int value)
        {
            InnerArray(ref array, value,0);
        }
        static  void AddLast(ref int[] array, int value)
        {
            InnerArray(ref array, value, array.Length);
        }
    }
    
    
}
