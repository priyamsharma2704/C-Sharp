namespace bestTimeToSellStocks2;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Assert.Equal(7,Program.MaxProfit([7,1,5,3,6,4]));
    }

    [Fact]
    public void Test2()
    {
        Assert.Equal(4,Program.MaxProfit([1,2,3,4,5]));
    }

    [Fact]
    public void Test3()
    {
        Assert.Equal(0,Program.MaxProfit([7,6,4,3,1]));
    }
}