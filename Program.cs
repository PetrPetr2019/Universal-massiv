using System;
using System.Linq;
using System.Xml.Serialization;


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
            #region Find the sum of even numbers in the array
            ///////////////////////////////////////////Find the sum of even numbers in the array/////////////////////////////////////////////////////////////

            //int[] maArray = { 1, 2, 3, 4, 5, 6, 7, 8 };
            //for (int i = 0; i < maArray.Length; i++)
            //{
            //    Console.WriteLine("\nOutput of the initial array" + maArray[i]);
            //}


            //for (int i = 0; i < maArray.Length; i++)
            //{
            //   if(maArray[i]%2==0)
            //    {
            //        Console.WriteLine("\nOutput of even array elements" +  maArray[i]);
            //    }
            //}
            #endregion
            #region show myArray

            ////int[] myArray = {1, 2, 3};
            //string[] myString = { "Test", "Hello", "Tomas"};

            //Resize(ref myString, 1);

            #endregion
            #region rezult Array
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////< меньше   > Больше//////////////////////////
            //int[] myArray = {1, 4, 6, 2};
            //AddFirst(ref myArray, -5);
            //AddLast(ref myArray, 9);
            //InnerArray<T>(ref myArray, -5, 0); // // If we specify zero 0 in place 2 , then we will add an element to the beginning of the array
            //AddFirst(ref myArray, -5);
            //AddLast(ref myArray,-5 );
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            #endregion
            #region Output of the minimum and maximum elements of the array

            //////////////////////////////////////////Output of the minimum and maximum elements of the array///////////////////////////////////////////////////////////////
            //int[] myArray = { 10, 23, 45, 6, 12, 7, 89, 11 };
            //massArray(ref myArray, myArray.Length);

            //for (int i = 0; i < myArray.Length; i++)
            // {
            //     Console.WriteLine("Array output" + myArray[i],Console.ForegroundColor = ConsoleColor.Yellow);

            // }
            #endregion
            #region выводы условий 
            //int[] myArray = { 12, 3, 23, 12, 34, 5, 345, 5, 3 };
            // //int result =    Array.FindLast(myArray, i =>i < 346 );
            // //Console.WriteLine(result);
            // int result = myArray.Where(t => t < 50).FirstOrDefault();
            //SortMass<int>(ref myArray);
            //Console.WriteLine(myArray.Where(t=>t%2!=0).Min());
            //int[] result = myArray.Distinct().ToArray(); // Вывести уникальные элементы в массиве
            //var result = myArray.OrderByDescending(t => t).ToArray();// Отсортировать массив по возрастанию
            //Array.Sort(myArray);
            #endregion
            #region Четные числа в массиве

            //for (int i = 0; i < 10; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //Array.Reverse(myArray);
            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    Console.WriteLine(myArray[i]);
            //}
            #endregion
            #region Вывод массива в обратном порядке
            //int[] myArray = {1, 2, 3, 4 ,5, 6, 7};
            //Console.WriteLine("Вывод массива");
            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    Console.WriteLine($"\t\t{myArray[i]}");
            //}
            //Array.Reverse(myArray);
            //Console.WriteLine("Обратный порядок");
            //foreach (var item in myArray)
            //{
            //    Console.WriteLine($"\t\t{item}");   
            //}
            #endregion
            #region MassFindAll
            //int[] myArray = {1, 2, 3, 4, 12, 44, 1};
            //var result = Array.FindAll(myArray, i => i < 2).ToArray();
            #endregion
            #region MyArrayGetLength
            //var myArray = new[,]
            //{
            //    {2,3,4,556,6},
            //    {4,5,43,2,67},
            //    {55,7,4,0,45},
            //    {4,56,7,4,3},
            //    {45,5,6,7,22}
            //};

            //for (int i = 0; i <myArray.GetLength(0); i++)
            //{
            //    for (int j = 0; j < myArray.GetLength(1); j++)
            //    {

            //        Console.Write(myArray[i,j] + "\t");
            //    }

            //    Console.WriteLine();

            //}
            #endregion
            #region Array Random
            //int[,] myArray = new int[10, 6];
            //Random rnd = new Random();

            //for (int i = 0; i < myArray.GetLength(0); i++)
            //{
            //    for (int j = 0; j < myArray.GetLength(1); j++)
            //    {
            //        myArray[i, j] = rnd.Next(100);
            //    }

            // }
            //for (int i = 0; i < myArray.GetLength(0); i++)
            //{
            //    for (int j = 0; j < myArray.GetLength(1); j++)
            //    {
            //        Console.Write(myArray[i, j] + "\t");
            //    }

            //    Console.WriteLine();
            //}
            #endregion



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
        #region Output of the minimum and maximum elements of the array
        //private static void massArray(ref int[] array, int min)
        //{

        //    for (var i = 0; i < array.Length; i++)
        //    {
        //        if (min > array[i])
        //        {
        //            min = array[i];

        //        }
        //    }
        //    Console.WriteLine("Minimum element in the array:" +  min, Console.ForegroundColor = ConsoleColor.Black);


        //}
        #endregion
        #region BubleSortMass

        // public static void SortMass<T>(ref int[] array)
        //{
        //    int temp;
        //     for (int i = 0; i <array.Length ; i++)
        //     {
        //         for (int j = i; j < array.Length; j++)
        //         {
        //            if(array[i] < array[j])
        //            {
        //                temp = array[i];
        //                array[i] = array[j];
        //                array[j] = temp;
        //            }
        //         }
        //    }
        //}
         #endregion
    }
}



















