using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public static class Arrays
    {
        public static void ArrayStuff()
        {
            int[] numberArray = new int[5];
            int[] nArray = new int[] { 12, 5, 9, 15, 45 };

            string[] names = new string[] { "Luke", "Leia", "Han", "Lando" };
            
            foreach(var item in names)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
           
        }
    }
}
