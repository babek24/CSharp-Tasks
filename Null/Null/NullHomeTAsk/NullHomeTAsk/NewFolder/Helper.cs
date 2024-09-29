

namespace NullHomeTAsk.NewFolder
{
    public static class Helper
    {
        public static DateTime? GetEarlierDateTime(DateTime? date1, DateTime? date2)
        {

            if (date1 == null && date2 == null)
            {
                return null; // Both are null
            }

            else if (date1 == null)
            {
                return date2; // date1 is null, return date2
            }
            else if (date2 == null)
            {
                return date1; // date2 is null, return date1
            }
            else 
            {
                return date1 < date2 ? date1 : date2; //'?'Ternary operator-if sert evez edicisi
            }
            

           
        }
        //Write a method that takes a dictionary of string keys and nullable integer values. 
        //If a value is null, set it to the specified default value using the null - coalescing assignment operator (??=).
        //Return the modified dictionary.
        public static Dictionary<string, int?> ModifieDictionary(Dictionary<string, int?> dict)
        {
            foreach (KeyValuePair<string, int?> item in dict)
            {
               //if( item.Value is null) //birinci usul
               // {
               //     dict[item.Key] = 0;
               // }
               //------------------------------------------------------------------
              dict[item.Key] ??=0; // Ikinci usul
            }

            return dict;

        }
    }

}

