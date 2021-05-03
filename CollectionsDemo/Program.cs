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
            DoQueueDemo();
            Console.WriteLine("--------------------------");
            DoSetDemo();
            Console.WriteLine("--------------------------");
            DoDictionaryDemo();
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
        private static void DoQueueDemo()
        {
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Ted");
            queue.Enqueue("Barney");
            queue.Enqueue("Robin");
            queue.Enqueue("Marshal");
            Console.WriteLine("Head: " + queue.Peek());
            Console.WriteLine("Members in Queue (iteration):");
            foreach (var person in queue)
            {
                Console.WriteLine(person);
            }
            string dequeue = queue.Dequeue();
            Console.WriteLine("\nDequeued Person: " + dequeue);
            Console.WriteLine("\nIterating the queue after dequeue one person:");
            Queue<string>.Enumerator enumerator = queue.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }
        private static void DoSetDemo()
        {
            Console.WriteLine("In Set: ");
            HashSet<string> set = new HashSet<string>();
            set.Add("Chandler");
            set.Add("Joey");
            set.Add("Ross");
            set.Add("Monica");
            HashSet<string>.Enumerator enumerator = set.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }
        private static void DoDictionaryDemo()
        {
            Console.WriteLine("In Dictionary: ");
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(111, "Ganesh");
            dictionary.Add(101, "Shyam");
            dictionary.Add(110, "Aditya");
            dictionary.Add(011, "Bhaskar");
            Console.WriteLine("Accessing Value using Key-111: " + dictionary[111]);
            Console.WriteLine("\nIterating Dictionary: ");
            foreach (var person in dictionary)
            {
                Console.WriteLine("Key: " + person.Key + " and value: " + person.Value);
            }
        }
    }
}
