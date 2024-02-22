namespace rotateArray;

/*
Given an integer array nums, rotate the array to the right by k steps, 
where k is non-negative.

Example 1:

Input: nums = [1,2,3,4,5,6,7], k = 3
Output: [5,6,7,1,2,3,4]
Explanation:
rotate 1 steps to the right: [7,1,2,3,4,5,6]
rotate 2 steps to the right: [6,7,1,2,3,4,5]
rotate 3 steps to the right: [5,6,7,1,2,3,4]

Example 2:

Input: nums = [-1,-100,3,99], k = 2
Output: [3,99,-1,-100]
Explanation: 
rotate 1 steps to the right: [99,-1,-100,3]
rotate 2 steps to the right: [3,99,-1,-100]


*/
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        int k = 3;
        int[] nums = [1,2,3,4,5,6,7];
        //Rotate(nums, k);
        rotateInPlace(nums, k);
    }
    
    public static void Rotate(int[] nums, int k) 
    {
        int len = nums.Length;
        int[] res = new int[len];

        for(int i = 0; i< len; i++)
        {
            int idx = 0;
            if(len%2 == 0)
                idx = len-k+i;
            else
                idx = len-k-1+i;
                
            if(idx >= len)
                idx = idx - len;
            res[idx] = nums[i];
        }

        foreach(var item in res)
            Console.WriteLine(item);
    }

       public static void rotateInPlace(int[] nums, int k) 
    {
        int len = nums.Length;
        int[] res = new int[len];

        Array.Reverse(nums, len-k, k);
        Array.Reverse(nums, 0, len-k);
        Array.Reverse(nums);
        
        foreach(var item in nums)
            Console.WriteLine(item);
    }
}
