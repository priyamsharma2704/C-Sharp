namespace bestTimeToSellStocks;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Assert.Equal(5,Program.MaxProfit([7,1,5,3,6,4]));
    }

    [Fact]
    public void Test2()
    {
        Assert.Equal(0,Program.MaxProfit([7,6,4,3,1]));
    }

    [Fact]
    public void Test3()
    {
        Assert.Equal(2,Program.MaxProfit([2,4,1]));
    }
}