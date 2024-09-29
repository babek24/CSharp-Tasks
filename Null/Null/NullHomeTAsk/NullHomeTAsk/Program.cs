using NullHomeTAsk.NewFolder;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace NullHomeTAsk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a method that takes two nullable DateTime objects and returns the earlier of the two.
            //If both are null, return null.If one is null, return the other.
            //------------------------------------------------------------------------------------------------
            //Write a method that takes a dictionary of string keys and nullable integer values. 
            //If a value is null, set it to the specified default value using the null - coalescing assignment operator (??=).
            //Return the modified dictionary.
           // DateTime? date1 = new DateTime();
           // DateTime? date2 = new DateTime(2024,12,2);
           // DateTime? earlierDate = Helper.GetEarlierDateTime(null,date2);
           // Console.WriteLine(earlierDate);
           // Helper helper = new Helper();   
            
            // static ona gore yazilir ki bu klas seviyyesindedir, obyekt yox

            
            Dictionary<string,int?> dictionary = new Dictionary<string,int?>();
            dictionary.Add("Car", 4);
            dictionary.Add("Moon", null);
            dictionary.Add("Sun", 78);
            dictionary.Add("Test", null);
            dictionary=Helper.ModifieDictionary(dictionary);
            foreach (KeyValuePair<string, int?> item in dictionary)

            {
                Console.WriteLine(item.Key + " " + item.Value);
            }

        }
    }
}
