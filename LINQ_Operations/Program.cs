using System;

namespace LINQ_Operation
{
    public class Program
    {
        public static void WhereMethod()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var numQuery = (from num in arr
                           where (num % 2 == 0)
                           select (num)).ToList();
            
            foreach(var num in numQuery)
            {
                Console.WriteLine(num);
            }
        }

        public static void SortingMethod()
        {
            string[] words = { "the", "quick", "brown", "fox", "jumps" };
            var queery = from word in words
                         orderby word.Length descending
                         select word;

            foreach(var word in queery)
            {
                Console.WriteLine(word);
            }
        }

        public static void PrimarySorting()
        {
            String[] words = { "the", "quick", "brown", "fox", "jumps" };
            var queery = from word in words
                         orderby word.Substring(0,1)
                         select word;

            foreach (var word in queery)
            {
                Console.WriteLine(word);
            }
        }
        static void Main(string[] args)
        {

            WhereMethod();
            SortingMethod();
            PrimarySorting();    //Sorting based on one Condition
            SecondarySorting();
        }
    }
}