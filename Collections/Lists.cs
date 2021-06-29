using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public static class Lists
    {
        public static void ListStuff()
        {
            List<string> colors = new List<string>();

            colors.Add("blue");

            string color1 = "green";
            string color2 = "purple";

            colors.Add(color1);
            colors.Add(color2);

            //foreach (var item in colors)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.ReadLine();
            //colors.Add(Console.ReadLine());

            List<int> employeeNumbers = new List<int>();

            int[] ids = new int[] { 156, 856, 941, 874, 654 };

            employeeNumbers.AddRange(ids);

            //employeeNumbers.Remove(156);

            //foreach (var item in employeeNumbers)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.ReadLine();
            Console.WriteLine("Is yellow in the list of colors?");
            Console.WriteLine(colors.Contains("yellow"));
            Console.ReadLine();


            int listCount = colors.Count();
            Console.WriteLine($"The count of the colors list is: {listCount}");
            Console.ReadLine();

        }
    }
}
