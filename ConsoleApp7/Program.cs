using System.Collections.Generic;

namespace ConsoleApp7
{
   
    
        Dictionary<string, int> dict = new Dictionary<string, int>()
        {
            { "four", 4 },
            { "two", 2 },
            { "one", 1 },
            { "three", 3 },
        };
        var d = dict.OrderBy(pair => pair.Value);
        
        foreach (var pair in d)
            {
               Debug.Log($"{pair.Key} - {pair.Value}");
            }
       
    
}
