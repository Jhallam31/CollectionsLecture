using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public static class Dictionaries
    {
        public static void DictionaryStuff()
        {
            Dictionary<string, string> cityIndex = new Dictionary<string, string>();

            cityIndex.Add("USA", "Chicago, Indianapolis, New York City");
            cityIndex.Add("JPN", "Tokoyo, Osaka, Nagasaki");
            cityIndex.Add("FRN", "Paris, Marseilles, Bordeaux");
            cityIndex.Add("UK", "London, Edinburgh, Manchester");

            //foreach(var kvp in cityIndex)
            //{
            //    Console.WriteLine($"Key: {kvp.Key} Value: {kvp.Value}");
            //}
            //Console.ReadLine();
            cityIndex.Remove("FRN");
            
             
            if (cityIndex.ContainsKey("UK"))
            {
                cityIndex.Remove("UK");
            }
            foreach (var kvp in cityIndex)
            {
                Console.WriteLine($"Key: {kvp.Key} Value: {kvp.Value}");
            }
            Console.ReadLine();
        }
    }
}
