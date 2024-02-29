namespace productOfArrayExceptItself;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Assert.Equal(new int [] {24,12,8,6}, Program.ProductExceptSelf(new int[] {1,2,3,4}));
    }

    [Fact]
    public void Test2()
    {
        Assert.Equal(new int [] {0,0,9,0,0}, Program.ProductExceptSelf(new int[] {-1,1,0,-3,3}));
    }
}