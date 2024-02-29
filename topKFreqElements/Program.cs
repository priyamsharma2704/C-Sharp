using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace topKFreqElements
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] r = TopKFrequent(new int[]{1,1,1,2,2,3}, 2);
        }
        public static int[] TopKFrequent(int[] nums, int k) 
        {
            List<int> l = new List<int>();
            Dictionary<int, int>dict = new Dictionary<int, int>();
            for(var i = 0 ; i< nums.Length; i++)
            {
                if(!dict.ContainsKey(nums[i]))
                {
                    dict.Add(nums[i],1);
                }
                else
                    dict[nums[i]] += 1;
            }

            //sort the dict
            dict = dict.OrderByDescending(x => x.Value).ToDictionary(x =>x.Key, x=> x.Value);

            foreach(var item in dict)
                Console.WriteLine(item);

            int j = 1;
            foreach(var item in dict)
            {
                if(j <= k)
                {
                    l.Add(item.Key);
                }
                j++;
            }
            foreach(var item in l)
                Console.WriteLine(item);
            return l.ToArray();
        }
    }
}