namespace Assignment
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

            #region Q2(Aggregate) Return a list of customers and how many orders each has.

            //var Result = ListGenerator.CustomerList
            //.GroupBy(C => C.CustomerID)
            //.Select(g => new
            //{
            //    CustomerId = g.Key,
            //    OrderCount = g.Count()
            //})
            //.ToList();

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Q3(Aggregate) Return a list of categories and how many products each has

            //var Result = ListGenerator.ProductList
            //.GroupBy(p => p.Category)
            //.Select(g => new
            //{
            //    Category = g.Key,
            //    ProductCount = g.Count()
            //})
            //.ToList();

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Q4(Aggregate) Get the total of the numbers in an array.

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var Result = Arr.Count();

            //Console.WriteLine(Result);

            #endregion

            #region Q4(Aggregate) Get the total of the numbers in an array.

            //string filePath = @"Dictonary.txt";
            //string[] lines = File.ReadAllLines(filePath);
            //int TotalChars = 0;
            //foreach (var item in lines)
            //{
            //    TotalChars += item.Length;
            //}
            //Console.WriteLine(TotalChars);

            #endregion

            #region Q6(Aggregate) Get the length of the shortest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).

            //string filePath = @"Dictonary.txt";
            //string[] lines = File.ReadAllLines(filePath);

            //var Result = lines.Min(L => L.Length);

            //Console.WriteLine(Result);

            #endregion

            #region Q7(Aggregate) Get the length of the longest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //string filePath = @"Dictonary.txt";
            //string[] lines = File.ReadAllLines(filePath);

            //var Result = lines.Max(L => L.Length);

            //Console.WriteLine(Result);

            #endregion

        }
    }
}
