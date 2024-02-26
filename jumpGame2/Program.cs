using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestPlatform.ObjectModel.Client.Payloads;

namespace jumpGame2
{
    public class Program
    {
        public static void Main(string [] args)
        {
            int res = 0;
            res = Jump([2,3,1,1,4]);
        }

        public static int Jump(int[] nums)
        {
            int jump = 0;
            int farthest = -1;
            int lastJumpIdx = 0;
            for(var i = 0; i < nums.Length -1; i++)
            {
                farthest = Math.Max(nums[i] + i, farthest);
                if(i == lastJumpIdx)
                {
                    jump++;
                    lastJumpIdx = farthest;
                }
            }
            return jump;
        }
    }
}