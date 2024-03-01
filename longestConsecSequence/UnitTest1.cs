namespace longestConsecSequence;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Assert.Equal(4, Program.LongestConsecutive(new int[] {100,4,200,1,3,2}));
    }

    [Fact]
    public void Test2()
    {
        Assert.Equal(9, Program.LongestConsecutive(new int[] {0,3,7,2,5,8,4,6,0,1}));
    }

    [Fact]
    public void Test3()
    {
        Assert.Equal(3, Program.LongestConsecutive(new int[] {1,2,0,1}));
    }
}