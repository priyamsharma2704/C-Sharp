using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace longestConsecSequence
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int res = LongestConsecutive(new int[]{1,2,0,1});
           // res = LongestConsecutiveWithDups(new int[]{1,2,0,1});
        }

        public static int LongestConsecutive(int[] nums) 
        {
            if(nums.Length == 0)
                return 0;
            //sort the array.
            Array.Sort(nums);
            //loop over and keep the counter on the streak.

            int streak = 0;
            int longest = 0;

            for(var i = 1; i < nums.Length; i++)
            {
                //if there are any dupes, just continue
                if(nums[i] == nums[i-1])
                continue;

                if(nums[i] - nums[i-1] == 1)
                    streak++;
                else
                    streak = 0;

                if(streak > longest)
                    longest = streak;
            }

            return longest+1;
        }
    }
}