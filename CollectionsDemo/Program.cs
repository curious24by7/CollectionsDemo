using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to CollectionDemo!");
            DoListDemo();
            Console.WriteLine("--------------------------");
            Console.ReadKey();
        }
        private static void DoListDemo()
        {
            Console.WriteLine("In List:");
            List<string> list = new List<string>();
            list.Add("Howard");
            list.Add("Sheldon");
            list.Add("Leonard");
            list.Add("Raj");

            foreach (var person in list)
            {
                Console.WriteLine(person);
            }
        }
    }
}
