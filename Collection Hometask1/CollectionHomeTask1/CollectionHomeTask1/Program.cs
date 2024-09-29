namespace CollectionHomeTask1
{
    internal class Program
    {
        private static string word;
        private static object dictionary;

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your sentece");
            string sentence= Console.ReadLine().ToLower();
            string[] words = sentence.Split(' ',',','.','!','?');
            Dictionary<string, int> RepeatedWordCount = new Dictionary<string, int>();
            
            for (int i = 0; i < words.Length; i++)
            {
                if (RepeatedWordCount.ContainsKey(words[i]))
                {
                    int value = RepeatedWordCount[words[i]];
                    RepeatedWordCount[words[i]] = value + 1;
                }
                else
                {
                    RepeatedWordCount.Add(words[i], 1);
                    
                }
            }

                //foreach (KeyValuePair<string, int> kvp in RepeatedWordCount)
                //{
               
                //Console.WriteLine(kvp.Key + ":" + kvp.Value);
               
                //}
                 var sortedList = RepeatedWordCount.OrderBy(kvp => kvp.Key).ToList();

                 foreach (KeyValuePair<string,int> item in sortedList)
                 {
                Console.WriteLine(item.Key + ' ' + item.Value);
                 }






            
         
                
                   
            


               
                
            
                
            

        }
    }
}
