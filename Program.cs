using System;


namespace Universal_massiv
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Вывести массив в обратном порядке/заполнить массив с клавиатуры

            //Console.WriteLine("Enter an array with a caviatura");
            //int[] mass = new int[5];
            //for (int i = 0; i < 5; i++)
            //{
            //    mass[i] = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("Output of the array in reverse order");
            //int[] myArray = {1, 2, 3, 4};
            //for (int i = myArray.Length; i > 0; i--)
            //{
            //    Console.WriteLine(myArray[i - 1]);
            //}
            #endregion



            ///////////////////////////////////////////Find the sum of even numbers in the array/////////////////////////////////////////////////////////////

            int[] maArray = { 1, 2, 3, 4, 5, 6, 7, 8 };
            for (int i = 0; i < maArray.Length; i++)
            {
                Console.WriteLine("\nOutput of the initial array" + maArray[i]);
            }

           
            for (int i = 0; i < maArray.Length; i++)
            {
               if(maArray[i]%2==0)
                {
                    Console.WriteLine("\nOutput of even array elements" +  maArray[i]);
                }
            }
            #region show myArray

            ////int[] myArray = {1, 2, 3};
            //string[] myString = { "Test", "Hello", "Tomas"};

            //Resize(ref myString, 1);

            #endregion
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////< меньше   > Больше//////////////////////////
            //int[] myArray = {1, 4, 6, 2};
            //AddFirst(ref myArray, -5);
            //AddLast(ref myArray, 9);
            //InnerArray<T>(ref myArray, -5, 0); // // If we specify zero 0 in place 2 , then we will add an element to the beginning of the array
            //AddFirst(ref myArray, -5);
            //AddLast(ref myArray,-5 );
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////




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
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        #region Massiv_Insert_Add_T

        //    public static void Insert<T>(ref T[] array, T value, int index)
        //    {
        //        var arrayResult = new T[array.Length + 1];
        //        arrayResult[index] = value;
        //        for (int i = 0; i < index; i++)
        //        {
        //            arrayResult[i] = array[i];
        //        }
        //        for (int i = index; i < array.Length; i++)
        //        {
        //            arrayResult[i + 1] = array[i];
        //        }
        //        array = arrayResult;
        //    }
        //    public static void AddFirst(ref int[] array, int value)
        //    {
        //        Insert(ref array, value, 0);
        //    }

        //    private static void AddLast(ref int[] array, int value)
        //    {
        //        Insert(ref array, value, array.Length);
        //    }
        //}
        #endregion
    }
}



















