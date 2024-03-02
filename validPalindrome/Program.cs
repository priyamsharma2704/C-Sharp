using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace validPalindrome
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var retVal = IsPalindrome("A man, a plan, a canal: Panama");
        }

        public static bool IsPalindrome(string s) 
        {
            if(s.Length == 0)
                return true;

            string ret = "";
            //1. remove all special chars and spaces from the string
            foreach(char c in s)
            {
                if(c >= 65 && c <= 90 || c>=97 && c<=122)
                {
                    ret += c.ToString().ToLower();
                }
            }
            //2. go from start till middle of the string (diff cases for odd and evn lengths)
            var len = ret.Length/2;
            
            for(var i = 0 ; i <= len; i++)
            {
                if(ret[i] != ret[ret.Length-i-1])
                {
                    return false;
                }
            }

            return true;
        }
    }
}