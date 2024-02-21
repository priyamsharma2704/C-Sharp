namespace removeDuplicatesFromSortedArray2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        int res = 0;
        int[] nums = [0,0,1,1,1,1,2,3,3];
        res = RemoveDuplicates(nums);
        Console.WriteLine(res);
    }

    public static int RemoveDuplicates(int[] nums) 
    {
        int i = 0;
        int j = 0;
        int occurance = 0;
        for(i = 0; i< nums.Length; i++)
        {
            if(nums[j] == nums[i])
            {
                occurance++;
                continue;
            }

            if(occurance > 2)
                j++;

            if(nums[j] < nums[i] && occurance > 2)
            {
                j++;
                nums[j] = nums[i];
                occurance = 0;
            }
        }
        return 0;
    }
}
