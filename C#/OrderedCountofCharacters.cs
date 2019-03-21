namespace Solution {
    using System;
    using System.Collections.Generic;
    using System.Linq;
    
    public class Kata {
        public static List<Tuple<char, int>> OrderedCount(string input) {
        Console.WriteLine(input);
        List < Tuple<char, int> > result = new List<Tuple<char, int>>();
        List<char> list = new List<char>(input.ToCharArray());
        var dict = list.GroupBy(c => c).ToDictionary(c => c.Key, c => c.Count());//.OrderByDescending(key=>key.Value);

        foreach (KeyValuePair<char, int> entry in dict)
        {
            result.Add(new Tuple<char, int>(entry.Key, entry.Value));
        }

    return result;
        }
    }
}
