using System.Collections;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Hash Table
            //Hashtable note = new Hashtable()
            //{
            //    ["mohamd"] = 123,
            //    ["Ahmed"]=456,
            //    ["mahmoud"]=478281
            //};
            //Console.WriteLine( note["Manar"]);//will return null if there is not  found

            ////note.Add("Ahmed", 789568);//will return exception [un save code]

            
            //// save code 
            //if (!note.ContainsKey("Ahmed"))
            //    note.Add("Ahmed", 655471717);

            //foreach (DictionaryEntry entry in note)
            //{
            //    Console.WriteLine( entry.Key+" "+entry.Value );
            //}

            #endregion

            #region Dectionary
            Dictionary<string,int> note = new Dictionary<string,int>()
            {
                ["mohamd"] = 123,
                ["Ahmed"] = 456,
                ["mahmoud"] = 478281
            };
            Console.WriteLine(note["Manar"]);//will return null if there is not  found

            //note.Add("Ahmed", 789568);//will return exception [un save code]


            // save code 
            //if (!note.ContainsKey("Ahmed"))
            //    note.Add("Ahmed", 655471717);

            //foreach (var entry in note)
            //{
            //    Console.WriteLine(entry.Key + " " + entry.Value);
            //}


            SortedDictionary<string, int> note1 = new SortedDictionary<string, int>()
            {
                ["mohamd"] = 123,
                ["Ahmed"] = 456,
                ["mahmoud"] = 478281
            };
            //is binary search tree add and delete in o(log(N)) 

            SortedList<string, int> note2 = new SortedList<string, int>()
            {
                ["mohamd"] = 123,
                ["Ahmed"] = 456,
                ["mahmoud"] = 478281
            };
            //is two array one for key another for value
            //used for sorted items
            //add/remove in o(n)


            #endregion

        }
    }
}
