using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jumpGame
{
    public class Program
    {
        public static void main(string [] args)
        {
            bool res;
            res = CanJump([]);
        }

        public static bool CanJump(int[] nums) 
        {
            int good = nums[nums.Length-1];
            for(var i = nums.Length-1; i>=0; i--)
            {
                if(i + nums[i] >= good)
                    good = i;
            }
            return good == 0;
        }
    }
}