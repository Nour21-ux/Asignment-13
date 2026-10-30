using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Asignment_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Element Operators
            //1. Get first Product out of Stock 
            //var result = ListGenerators.ProductList.FirstOrDefault(p => p.UnitsInStock == 0);
            //Console.WriteLine(result);

            //2. Return the first product whose Price > 1000, unless there is no match, in which case null is returned.
            //var result = ListGenerators.ProductList.FirstOrDefault(p => p.UnitPrice > 100);
            //Console.WriteLine(result);

            //3. Retrieve the second number greater than 5 
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result=Arr.Where(n=>n>5)
            //              .Skip(1)
            //              .First();

            //Console.WriteLine(result);
            #endregion

            #region Aggregate Operators

            //1. Uses Count to get the number of odd numbers in the array
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result=Arr.Count(n=>n%2!=0);

            //2. Return a list of customers and how many orders each has.
            //var result = ListGenerators.CustomerList.Select(C => new
            //{
            //    CustomerName = C.Name,
            //    OrderCount = C.Orders.Count(),
            //});
            //foreach (var item in result) 
            //    Console.WriteLine(item);

            //3. Return a list of categories and how many products each has
            //var result = ListGenerators.ProductList.GroupBy(P => P.Category)
            //                                        .Select(C=>new
            //                                        {
            //                                            Category=C.Key,
            //                                            productCount=C.Count()
            //                                        }).ToList();
            //foreach (var item in result) 
            //    Console.WriteLine(item);

            //4. Get the total of the numbers in an array.
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result=Arr.Sum(x => x);

            //5. Get the total number of characters of all words in dictionary_english.txt
            //(Read dictionary_english.txt into Array of String First).

            //String[] wordsarray=File.ReadAllLines("dictionary_english.txt");
            //var result = wordsarray.Select(w => new
            //{
            //    word = w,
            //    totalnumberofchar = w.Length
            //});
            //foreach (var word in result)
            //    Console.WriteLine(word);


            //6. Get the length of the shortest word in dictionary_english.txt
            //(Read dictionary_english.txt into Array of String First).

            //String[] wordsarray=File.ReadAllLines("dictionary_english.txt");
            //var result = wordsarray.OrderByDescending(x => x.Length).Last().Length;
            //Console.WriteLine(result);

            //7. Get the length of the longest word in dictionary_english.txt
            //(Read dictionary_english.txt into Array of String First).
            //String[] wordsarray = File.ReadAllLines("dictionary_english.txt");
            //var result = wordsarray.MaxBy(x => x.Length).Length;
            //Console.WriteLine(result);

            //8. Get the average length of the words in dictionary_english.txt
            //(Read dictionary_english.txt into Array of String First).
            //String[] wordsarray = File.ReadAllLines("dictionary_english.txt");
            //var result = wordsarray.Average(x => x.Length);
            //Console.WriteLine(result);



            #endregion

            #region LINQ - Set Operators
            //1. Find the unique Category names from Product List
            //var result=ListGenerators.ProductList.Select(x => x.Category).Distinct();
            //foreach (var item in result)
            //    Console.WriteLine(item);

            //2. Produce a Sequence containing the unique first letter from both product and customer names.
            //var pr = ListGenerators.ProductList.Select(p => p.ProductName[0]);
            //var customer = ListGenerators.CustomerList.Select(c => c.Name[0]);
            //var result=pr.Union(customer).Distinct().ToList();
            //foreach (var item in result)
            //    Console.WriteLine(item);

            //3. Create one sequence that contains the common first letter from both product and customer names.
            //var pr = ListGenerators.ProductList.Select(p => p.ProductName[0]);
            //var customer = ListGenerators.CustomerList.Select(c => c.Name[0]);
            //var result = pr.Intersect(customer).ToList();
            //foreach (var item in result)
            //    Console.WriteLine(item);

            //4. Create one sequence that contains the first letters of product names that are not also first letters of customer names.
            //var pr = ListGenerators.ProductList.Select(p => p.ProductName[0]);
            //var customer = ListGenerators.CustomerList.Select(c => c.Name[0]);
            //var result = pr.Except(customer).ToList();
            //foreach (var item in result)
            //    Console.WriteLine(item);

            //5. Create one sequence that contains the last Three Characters in each name of all customers and products, including any duplicates
            //var pr = ListGenerators.ProductList.Select(p => p.ProductName.Substring(p.ProductName.Length-3));
            //var customer = ListGenerators.CustomerList.Select(c => c.Name.Substring(c.Name.Length-3));
            //var result = pr.Concat(customer).ToList();
            //foreach (var item in result)
            //    Console.WriteLine(item);

            #endregion

            #region LINQ - Partitioning Operators
            //1. Get the first 3 orders from customers in Washington

            //var result = ListGenerators.CustomerList.Where(c => c.Country == "Washington").Select(c=>c.Orders)
            //                                      .Take(3);

            //3.Return elements starting from the beginning of the array until a number is hit that is less than its position in the array.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = numbers.TakeWhile((n,i) => n >= i);
            //foreach (var i in result)
            //    Console.WriteLine(i);

            //4.Get the elements of the array starting from the first element divisible by 3.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = numbers.SkipWhile(n=>n%3!=0);
            //foreach (var i in result)
            //    Console.WriteLine(i);

            //5. Get the elements of the array starting from the first element less than its position.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = numbers.SkipWhile((n, i) => n >= i);
            //foreach (var i in result)
            //    Console.WriteLine(i);
            #endregion

            #region LINQ - Quantifiers
            //1. Determine if any of the words in dictionary_english.txt
            //(Read dictionary_english.txt into Array of String First) contain the substring 'ei'.
            //string[] wordsarray = File.ReadAllLines("dictionary_english.txt");
            //var result=wordsarray.Any(w=>w.Contains("ei"));
            //Console.WriteLine(result);

            //2. Return a grouped a list of products only for categories that have at least one product that is out of stock.
            //var result = ListGenerators.ProductList.GroupBy(p => p.Category).Where(g => g.Any(p => p.UnitsInStock == 0)).ToList();

            //foreach (var group in result)
            //{
            //    Console.WriteLine($"\nCategory: {group.Key}");
            //    foreach (var product in group)
            //    {
            //        Console.WriteLine($"   {product.ProductName} - Stock: {product.UnitsInStock}");
            //    }
            //}

            //3. Return a grouped a list of products only for categories that have all of their products in stock.
            //var result = ListGenerators.ProductList.GroupBy(p => p.Category).Where(g => g.All(p => p.UnitsInStock == 0)).ToList();

            //foreach (var group in result)
            //{
            //    Console.WriteLine($"\nCategory: {group.Key}");
            //    foreach (var product in group)
            //    {
            //        Console.WriteLine($"   {product.ProductName} - Stock: {product.UnitsInStock}");
            //    }
            //}
            #endregion

            #region LINQ – Grouping Operators
            //1.	Use group by to partition a list of numbers by their remainder when divided by 5
            //List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            //var partitionedQuery = from n in numbers
            //                       group n by n % 5 ;

            //foreach (var group in partitionedQuery)
            //{
            //    Console.WriteLine($"numbers with the remainder of {group.Key} when devided by 5:\n{string.Join("\n", group)}");
            //}



            //2.	Uses group by to partition a list of words by their first letter.
            //Use dictionary_english.txt for Input

            //string[] words = File.ReadAllLines("dictionary_english.txt");
            //var result = from w in words
            //             group w by w[0];
            //foreach (var word in result)
            //{
            //    Console.WriteLine($"letter: {word.Key} : \n{string.Join(",", word)}");
            //}

            

            #endregion
        }
    }
}
