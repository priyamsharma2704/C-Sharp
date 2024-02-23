namespace jumpGame;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Assert.True(Program.CanJump([2,3,1,1,4]));
    }

    [Fact]
    public void Test2()
    {
        Assert.False(Program.CanJump([3,2,1,0,4]));
    }
}