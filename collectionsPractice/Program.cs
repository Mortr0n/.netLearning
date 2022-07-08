using System;
using System.Linq.Expressions;

namespace CollectionsPractice
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] oneToNine = {1,2,3,4,5,6,7,8,9};
            string[] names = {"Tim", "Martin", "Nikki", "Sara"};
            bool[] boolArr = {true, false, true, false, true, false, true, false, true, false};
            
            List<string> flavors = new List<string>();
                flavors.Add("Chocolate");
                flavors.Add("Vanilla");
                flavors.Add("Strawberry");
                flavors.Add("Mint");
                flavors.Add("Black Licorice");
                Console.WriteLine(flavors.Count);
                Console.WriteLine(flavors[2]);
                flavors.Remove("Strawberry");
                Console.WriteLine(flavors.Count);
            
            Random rand = new Random();

            Dictionary<string, string> nameAndFlavor = new Dictionary<string, string>();
            for(int i = 0; i<names.Length; i++){
                nameAndFlavor.Add(names[i], flavors[rand.Next(0,flavors.Count)]);
            }
            foreach(KeyValuePair<string, string> entry in nameAndFlavor) {
                Console.WriteLine($"{entry.Key}'s favorite ice cream flavor is {entry.Value}");
            }

        }
    }
}