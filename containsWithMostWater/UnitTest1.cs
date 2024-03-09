namespace containsWithMostWater;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Assert.Equal(49, Program.MaxArea([1,8,6,2,5,4,8,3,7]));
    }

    [Fact]
    public void Test2()
    {
        Assert.Equal(1, Program.MaxArea([1,1]));
    }
}