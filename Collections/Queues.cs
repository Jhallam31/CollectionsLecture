using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public static class Queues
    {
        public static void QueueStuff()
        {
            Queue<string> example = new Queue<string>();

            example.Enqueue("One");
            example.Enqueue("Two");
            example.Enqueue("Three");
            example.Enqueue("Four");
            example.Enqueue("Five");
            example.Enqueue("Six");

            foreach (var item in example)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

            Console.WriteLine(example.Peek());
            Console.ReadLine();

            Console.Clear();
            example.Dequeue();

            foreach (var item in example)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
