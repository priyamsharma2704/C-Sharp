namespace jumpGame2;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Assert.Equal(2, Program.Jump([2,3,1,1,4]));
    }

    [Fact]
    public void Test2()
    {
        Assert.Equal(2, Program.Jump([2,3,0,1,4]));
    }
}