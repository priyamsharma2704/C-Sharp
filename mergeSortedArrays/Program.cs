namespace mergeSortedArrays;
/*
You are given two integer arrays nums1 and nums2, sorted in non-decreasing order, 
and two integers m and n, representing the number of elements in nums1 and nums2 
respectively.

Merge nums1 and nums2 into a single array sorted in non-decreasing order.

Example 1:

Input: nums1 = [1,2,3,0,0,0], m = 3, nums2 = [2,5,6], n = 3
Output: [1,2,2,3,5,6]
Explanation: The arrays we are merging are [1,2,3] and [2,5,6].
The result of the merge is [1,2,2,3,5,6] with the underlined elements coming from nums1.


*/
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        int[] nums1 = [1,2,3,0,0,0];
        int[] nums2 = [2,5,6];
        int m = 3;
        int n = 3;
        Merge(nums1,m,nums2, n);
    }

    public static void Merge(int[] nums1, int m, int[] nums2, int n) 
    {
        for(var i = 0; i < n; i++)
        {
            nums1[m+i] = nums2[i];
        }

        Array.Sort(nums1);
    }
}
