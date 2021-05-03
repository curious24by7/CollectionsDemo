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
            DoStackDemo();
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
        private static void DoStackDemo()
        {
            Console.WriteLine("In Stack:");
            Stack<string> stack = new Stack<string>();
            stack.Push("Bertram");
            stack.Push("Richard");
            stack.Push("Dinesh");
            stack.Push("Jared");
            string Pop = stack.Pop();
            foreach (var person in stack)
            {
                Console.WriteLine(person);
            }
            Console.WriteLine("Popped Person:: " + Pop);
        }
    }
}
