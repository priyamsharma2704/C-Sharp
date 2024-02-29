namespace topKFreqElements;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Assert.Equal(new int[]{1,2}, Program.TopKFrequent(new int[]{1,1,1,2,2,3}, 2));
    }

    [Fact]
    public void Test2()
    {
        Assert.Equal(new int[]{1}, Program.TopKFrequent(new int[]{1}, 1));
    }
}