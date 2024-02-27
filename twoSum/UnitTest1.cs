namespace twoSum;

public class UnitTest1
{
    #nullable enable

    [Fact]
    public void Test1()
    {
        Assert.Equal(new int[] { 1, 2 }, Program.TwoSum(new int[] { 3, 2, 4 }, 6));
    }

    [Fact]
    public void Test2()
    {
        Assert.Equal(new int[] { 0, 1 }, Program.TwoSum(new int[] { 2, 7, 11, 15 }, 9));
    }

    [Fact]
    public void Test3()
    {
        Assert.Equal(new int[] { 0, 1 }, Program.TwoSum(new int[] { 3, 3 }, 6));
    }

    [Fact]
    public void Test4()
    {
        Assert.Equal(new int[] { 1,2 }, Program.TwoSum(new int[] { 2,5,5,11 }, 10));
    }
}