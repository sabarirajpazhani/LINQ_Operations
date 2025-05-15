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

        //Output: 2
        //        4
        //        6
        //        8

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


            //Output
            //    quick
            //    brown
            //    jumps
            //    the
            //    fox

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

            //Output
            //    brown
            //    fox
            //    jumps
            //    quick
            //    the
        }

        public static void SecondarySorting()
        {
            String[] words = { "the", "quick", "brown", "fox", "jumps" };
            var queery = from word in words
                         orderby word.Length, word.Substring(0, 1)
                         select word;

            foreach (var word in queery)
            {
                Console.WriteLine(word);
            }

            //output

            //    fox
            //    the
            //    brown
            //    jumps
            //    quick

        }

        public static void Filtering()
        {
            String[] words = { "the", "quick", "brown", "fox", "jumps" };
            var queery = from word in words
                         orderby word.Length==3 && word.Substring(0, 1)=="f"
                         select word;

            foreach (var word in queery)
            {
                Console.WriteLine(word);
            }

            //Output:
            //fox
        }
        static void Main(string[] args)
        {

            //WhereMethod();
            //SortingMethod();
            //PrimarySorting();    //Sorting based on one Condition
            //SecondarySorting();   // Based on Two Condition
            Filtering();
        }
    }
}