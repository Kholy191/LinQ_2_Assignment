using System.Threading;

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

            #region Q8(Aggregate) Get the average length of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //string filePath = @"Dictonary.txt";
            //string[] lines = File.ReadAllLines(filePath);

            //var Result = lines.Average(L => L.Length);

            //Console.WriteLine(Result);

            #endregion

            #region Q9(Aggregate) Get the total units in stock for each product category.

            //var Result = ListGenerator.ProductList.Where(p => p.UnitsInStock > 0)
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

            #region Q10(Aggregate) Get the cheapest price among each category's products

            //var Result = ListGenerator.ProductList.Where(p => p.UnitsInStock > 0)
            //.GroupBy(p => p.Category)
            //.Select(g => new
            //{
            //    Category = g.Key,
            //    CheapestPrice = g.Min(p => p.UnitPrice)
            //})
            //.ToList();

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Q12(Aggregate) Get the products with the cheapest price in each category (Use Let)

            //var Result = ListGenerator.ProductList.Where(p => p.UnitsInStock > 0)
            //.GroupBy(p => p.Category)
            //.Select(g => new
            //{
            //    Category = g.Key,
            //    CheapestPrice = g.Max(p => p.UnitPrice)
            //})
            //.ToList();

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Q13(Aggregate) Get the products with the cheapest price in each category (Use Let)

            //var mostExpensiveProductsByCategory = ListGenerator.ProductList
            //           .GroupBy(p => p.Category)
            //           .Select(g => new
            //           {
            //               Category = g.Key,
            //               MostExpensiveProducts = g.Where(p => p.UnitPrice == g.Max(p2 => p2.UnitPrice)).ToList()
            //           })
            //           .ToList();

            #endregion

            #region Q14(Aggregate) Get the average price of each category's products.

            //var mostExpensiveProductsByCategory = ListGenerator.ProductList
            //           .GroupBy(p => p.Category)
            //           .Select(g => new
            //           {
            //               Category = g.Key,
            //               MostExpensiveProducts = g.Average(P => P.UnitPrice)
            //           })
            //           .ToList();
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Q1(Ordering) Sort a list of products by name

            //var Result = ListGenerator.ProductList.OrderBy(P => P.ProductName);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Q2(Ordering) Uses a custom comparer to do a case-insensitive sort of the words in an array.
            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var Result = Arr.OrderBy(P => P);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Q3(Ordering)  Sort a list of products by units in stock from highest to lowest.

            //var Result = ListGenerator.ProductList.OrderByDescending(P => P.UnitsInStock);

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Q4(Ordering)  Sort a list of digits, first by length of their name, and then alphabetically by the name itself.


            //string[] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
            //var Result = Arr.OrderBy(P => P.Length).ThenBy(P => P);

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Q5(Ordering) Sort first by-word length and then by a case-insensitive sort of the words in an array.


            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var Result = Arr.OrderBy(P => P.Length).ThenBy(P => P ,StringComparer.OrdinalIgnoreCase);

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Q6(Ordering) 6. Sort a list of products, first by category, and then by unit price, from highest to lowest.


            //var Result = ListGenerator.ProductList.OrderByDescending(P => P.Category).ThenByDescending(p => p.UnitPrice);

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Q7(Ordering)  Sort first by-word length and then by a case-insensitive descending sort of the words in an array.


            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var Result = Arr.OrderByDescending(P => P.Length).ThenByDescending(P => P, StringComparer.OrdinalIgnoreCase);

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Q8(Ordering)  Sort first by-word length and then by a case-insensitive descending sort of the words in an array.

            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var Result = Arr
            //      .Where(word => word.Length > 1 && word[1] == 'i')
            //     .Reverse()
            //    .ToArray();

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            /*LINQ - Set Operators*/

            #region Q1[Set] Find the unique Category names from Product List
            //var Result = ListGenerator.ProductList.Select(P => P.Category).Distinct();
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Q2[Set] Produce a Sequence containing the unique first letter from both product and customer names.
            //var Result = ListGenerator.ProductList
            //          .Select(p => p.ProductName[0])
            //          .Union(ListGenerator.CustomerList.Select(c => c.CustomerName[0]))
            //          .Distinct();
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Q3[Set] Create one sequence that contains the common first letter from both product and customer names.
            //var Result = ListGenerator.ProductList
            //          .Select(p => p.ProductName[0])
            //          .Intersect(ListGenerator.CustomerList.Select(c => c.CustomerName[0]));
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Q4[Set] Create one sequence that contains the first letters of product names that are not also first letters of customer names.
            //var Result = ListGenerator.ProductList
            //          .Select(p => p.ProductName[0])
            //          .Except(ListGenerator.CustomerList.Select(c => c.CustomerName[0]));
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion


            #region Q5[Set] Create one sequence that contains the last Three Characters in each name of all customers and products, including any duplicates
            //var Result = ListGenerator.ProductList
            //          .Select(p => p.ProductName.Length >= 3 ? p.ProductName[^3..] : p.ProductName)
            //          .Concat(ListGenerator.CustomerList.Select(c => c.CustomerName.Length >= 3 ? c.CustomerName[^3..] : c.CustomerName));

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
        }
    }
}
