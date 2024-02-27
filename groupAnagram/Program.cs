using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace groupAnagram
{
    public class Program
    {
        public static void Main(string [] args)
        {
            var res = GroupAnagram(new string[]{"eat","tea","tan","ate","nat","bat"});
        }

        public static IList<IList<string>> GroupAnagram(string[] strs)
        {
            Dictionary<string, IList<string>> dict = new Dictionary<string, IList<string>>();

            for(var i = 0; i < strs.Length; i++)
            {
                var sorted = String.Concat(strs[i].OrderBy(c=>c));   //sort the words alphabetically.
                if(!dict.ContainsKey(sorted))
                {
                    dict[sorted] = new List<string>();
                }
                dict[sorted].Add(strs[i]);
            }

            return dict.Values.ToList();
        }
    }
}