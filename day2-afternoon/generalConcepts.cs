using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class generalConcepts
    {
        public void combine_without_duplicates(string[] arr1, string[] arr2)
        {
            string[] finallArray = arr1.Union(arr2).ToArray();
            Array.ForEach(finallArray, Console.WriteLine);
        }

        public void sortArr(string[] arr1)
        {
            Array.Sort(arr1);
            Array.ForEach(arr1, Console.WriteLine);
        }
        public void studyingArray()
        {
            int[,] array2d = new int[2, 3]; //declaring 2d array wo any value

            int[,,] arr3d1 = new int[1, 2, 2]
            {
                 { { 1, 2 }, { 3, 4 } }
            };

            int[,,] arr3d2 = new int[2, 2, 2]
            {
                { {1, 2}, {3, 4} },
                { {5, 6}, {7, 8} }
            };

            int[,,] arr3d3 = new int[2, 2, 3]
            {
                { {1,2,3}, {1,4,5} },
                { {5,6,3}, {1,4,5}}
            };

            Console.WriteLine(arr3d2[1,2,0]);
        }

        internal void find_All_Elements_With_Length_Greater_Than(string[] arr1, int v)
        {
            string[] filteredArray = Array.FindAll(arr1, ele => ele.Length > v);
            Console.WriteLine(String.Join(" , ", filteredArray));
        }

        internal void removeDuplicates(string[] arr1)
        {
            var distincts = arr1.Distinct();
            Console.WriteLine($"Before making it an array --> {distincts.GetType()}"); //enumerable iterator?

            string[] distinct_array = distincts.ToArray();
            Console.WriteLine($"After making it to an array -> {String.Join(",",distinct_array)}");
        }

        internal void joinArray(string[] arr1)
        {
            var str = String.Join(",", arr1);
            Console.WriteLine(str);
        }

        internal void countElements(string[] arr1)
        {
            Console.WriteLine(arr1.Count());
        }

        public void assignment1_fn()
        {
            while (true)
            {
                string raw_userInp = Console.ReadLine();
                if (raw_userInp == "q")
                {
                    break;
                }
                int valid_userInp;
                bool ifSuccess = int.TryParse(raw_userInp, out valid_userInp);
                if (!ifSuccess)
                {
                    Console.WriteLine("Enter a Valid Integer");
                }
                else
                {
                    Console.WriteLine((int)(Math.Pow(valid_userInp, 2) + (2 * valid_userInp) + 1));
                }

            }

        }


        public static void unboxing()
        {
            Object Myobj = 30;
            int i = (int)Myobj; //Need Explit Conv because we are converting a Ref Type (object) to a Value Type (int)..For the reverse case, its not needed.
            Console.WriteLine(i);

        }

        public static void tryParsing()
        {
            string val = "21";
            int result;
            bool ifSuccess = int.TryParse(val, out result);
            Console.WriteLine(result);

            Console.WriteLine(ifSuccess);

            string val2 = "101.11";
            int result2;
            bool ifSuccess2 = int.TryParse(val2, out result2);

            Console.WriteLine(ifSuccess2);
        }
    }
}
