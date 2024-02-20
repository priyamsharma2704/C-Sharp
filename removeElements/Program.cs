
using System.Collections;

namespace removeElements;

/*
Given an integer array nums and an integer val, remove all occurrences of val in nums in-place. T
he order of the elements may be changed. Then return the number of elements in nums which are not equal to val.

Input: nums = [3,2,2,3], val = 3
Output: 2, nums = [2,2,_,_]
Explanation: Your function should return k = 2, with the first two elements of nums being 2.
It does not matter what you leave beyond the returned k (hence they are underscores).

Input: nums = [0,1,2,2,3,0,4,2], val = 2
Output: 5, nums = [0,1,4,0,3,_,_,_]
Explanation: Your function should return k = 5, with the first five elements of nums containing 0, 0, 1, 3, and 4.
Note that the five elements can be returned in any order.
It does not matter what you leave beyond the returned k (hence they are underscores).

*/
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        int[] nums = [0,1,2,2,3,0,4,2];
        int res = RemoveElement(ref nums, 2);
        Console.WriteLine(res);
    }

    public static int RemoveElement(ref int[] nums, int val)
    {
        int j = 0;
        for(int i = 0 ;i < nums.Length; i++)
        {
            if(nums[i] != val)
            {
                nums[j] = nums[i];
                j++;
            }
        }
        return j;
    }
}
