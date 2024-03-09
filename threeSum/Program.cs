using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace threeSum
{
    public class Program
    {
        public static void Main(string [] args)
        {
            var res = ThreeSum(new int[] {-1,0,1,2,-1,-4});
        }

        public static List<List<int>> ThreeSum(int[] nums)
        {
            List<List<int>> result = new List<List<int>>();

            if(nums.Length <= 2)
                return result;

            Array.Sort(nums);

            var start = 0;

            while(start < nums.Length - 2)
            {
                var target = nums[start] * -1;
                var left = start + 1;
                var right = nums.Length -1;

                while(left < right)
                {
                    if(nums[left] + nums[right] > target)
                        left += 1;
                    else if(nums[left] + nums[right] < target)
                        right -= 1;
                    else
                    {
                        List<int> pair = new List<int>(){nums[target], nums[left], nums[right]};
                        result.Add(pair);

                        while(left < right && nums[left] == pair[1])
                            left += 1;
                        while(left < right && nums[right] == pair[2])
                            right -= 1;
                    }
                }
                int temp = nums[start];
                while(start < nums.Length -1 && nums[start] == temp)
                    start += 1;
            }
            return result;
        }
    }
}