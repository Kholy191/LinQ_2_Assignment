﻿namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1(Element) Get first Product out of Stock 

            //var Result = ListGenerator.ProductList.Where(P => P.UnitsInStock == 0).FirstOrDefault();

            //Console.WriteLine(Result);

            #endregion

            #region Q2(Element) Return the first product whose Price > 1000, unless there is no match, in which case null is returned.

            //var Result = ListGenerator.ProductList.Where(P => P.UnitPrice > 1000).FirstOrDefault();

            //Console.WriteLine(Result);

            #endregion

            #region Q3(Element) Retrieve the second number greater than 5 

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var Result = Arr.Where(Num => Num > 5).ElementAt(1);

            //Console.WriteLine(Result);

            #endregion

            /*Aggregate Operators*/

            #region Q1(Aggregate) Uses Count to get the number of odd numbers in the array

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var Result = Arr.Where(Num => Num % 2 == 1).Count();

            //Console.WriteLine(Result);

            #endregion

        }
    }
}
