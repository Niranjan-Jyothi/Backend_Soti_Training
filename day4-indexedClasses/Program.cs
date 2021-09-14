using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4_indexedClasses
{
    class Program
    {
        
    }

    class IndexedClass
    {
        private string[] names = new string[10];

        static void Main(string[] args)
        {
            IndexedClass nameList = new IndexedClass();

            nameList[0] = "Ram";
            Console.WriteLine(nameList["Ram"]);
            Console.Read();
        }

        public string this[int index] //indexer method to writr values to array
        {
            get
            { 
                return (index >= 0 && index <= 9) ? names[index] : "";
            }
            set
            {
                if (index >=0 && index <= 9)
                {
                    names[index] = value;
                }
            }
        }

        public int this[string name] //indexer method to fetch the index based on the passed value
        {
            get
            {
                int index = 0;
                while (index < 10)
                {
                    if(names[index] == name)
                    {
                        return index;
                    }
                    index++;
                }
                return index;
            }
        }
    }
}
