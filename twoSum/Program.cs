using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace twoSum
{
    public class Program
    {
        public static void Main(string [] args)
        {
            int [] res;
            res = TwoSum(new int[] { 2,5,5,11 }, 10);
        }

        public static int [] TwoSum(int [] nums, int target)
        {
             int [] res = new int[2];
            // int i = 0;
            // int j = i +1;
            // while(i < nums.Length - 1)
            // {
            //     if(nums[i] + nums[j] == target)
            //     {
            //         res = new int[2];
            //         res[0] = i;
            //         res[1] = j;
            //         return res;
            //     }
            //     else if( nums[i] + nums[j] < target)
            //     {
            //         j++;
            //     }
            //     else if(nums[i] + nums[j] > target)
            //     {
            //         i++;
            //     }
            // }
            // return res;
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for(var i = 0; i < nums.Length; i++)
            {
                var diff = target - nums[i];
                if(dict.ContainsKey(diff))
                {
                    res[0] = dict[diff];
                    res[1] = i;
                    return res;
                }
                else if(!dict.ContainsKey(nums[i]))
                {
                    dict[nums[i]] = i;
                }
            }
            return res;
        }
    }
}