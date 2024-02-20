namespace removeDuplicatesFromSortedArray;
/*
Given an integer array nums sorted in non-decreasing order, remove the duplicates in-place such that 
each unique element appears only once. The relative order of the elements should be kept the same. 
Then return the number of unique elements in nums.

Input: nums = [1,1,2]
Output: 2, nums = [1,2,_]
Explanation: Your function should return k = 2, with the first two elements of nums being 1 and 2 respectively.
It does not matter what you leave beyond the returned k (hence they are underscores).

Input: nums = [0,0,1,1,1,2,2,3,3,4]
Output: 5, nums = [0,1,2,3,4,_,_,_,_,_]
Explanation: Your function should return k = 5, with the first five elements of nums being 0, 1, 2, 3, and 4 respectively.
It does not matter what you leave beyond the returned k (hence they are underscores).

*/
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        int[] nums = [0,0,1,1,1,2,2,3,3,4];
        int res = RemoveDuplicates(nums);
        Console.WriteLine(res);
    }

    public static int RemoveDuplicates(int[] nums) 
    {
        Dictionary<int,int> dict = new Dictionary<int, int>();

        foreach(var item in nums)
        {
            if(!dict.ContainsKey(item))
            {
                dict[item] = 1;
            }
        }

        int len = dict.Count;
        int i = 0;
        foreach(var key in dict.Keys)
        {
            nums[i] = key;
            i++;
        }

        Console.WriteLine(nums);
        return i;    
    }
}