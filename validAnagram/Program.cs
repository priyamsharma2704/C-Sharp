using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace validAnagram
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool res = false;
            res = IsAnagram("ab", "a");
        }
        public static bool IsAnagram(string s, string t)
        {
            if(s.Length != t.Length)
                return false;
                
            Dictionary<char, int> d1 = new Dictionary<char,int>();
            Dictionary<char, int> d2 = new Dictionary<char,int>();

            for(var i = 0 ; i < s.Length; i++)
            {
                if(!d1.ContainsKey(s[i]))
                    d1[s[i]] = 1;    
            else
                d1[s[i]] += 1;
            }

            for(var j = 0 ; j < t.Length; j++)
            {
                if(!d2.ContainsKey(t[j]))
                    d2[t[j]] = 1;    
            else
                d2[t[j]] += 1;
            }

            foreach(var item in d2)
            {
                if(d1.ContainsKey(item.Key))
                {
                    if(d1[item.Key] != item.Value)
                        return false;
                }
                else
                    return false;
            }
            return true;
        }

    }
}