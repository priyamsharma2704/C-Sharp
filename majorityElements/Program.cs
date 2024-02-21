namespace majorityElements;
/*
Given an array nums of size n, return the majority element.

The majority element is the element that appears more than ⌊n / 2⌋ times. 
You may assume that the majority element always exists in the array.

Example 1:

Input: nums = [3,2,3]
Output: 3

Example 2:

Input: nums = [2,2,1,1,1,2,2]
Output: 2


*/
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        int[] nums = [3,2,3];
        int res = 0;
        res = MajorityElement(nums);
        Console.WriteLine(res);
    }
    
    public static int MajorityElement(int[] nums) 
    {
        Dictionary<int,int> dict = new Dictionary<int, int>();
        int max = nums.Length/2;
        int res = 0;
        for(var i = 0; i < nums.Length; i++)
        {
            if(!dict.ContainsKey(nums[i]))
                dict[nums[i]] = 1;
            else
                dict[nums[i]] += 1;
        }

        foreach(var item in dict)
        {
            if(item.Value > max)
                res = item.Key;
        }
        return res;
    }
}
