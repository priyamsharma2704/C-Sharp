namespace threeSum;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        List<List<int>> list = [[-1,-1,2], [-1,0,1]];
        List<int> inputParam = new List<int>(){-1,0,1,2,-1,-4};

        Assert.Equal(list, Program.ThreeSum(inputParam.ToArray()));
    }

    [Fact]
    public void Test2()
    {
        List<List<int>> list = [];
        List<int> inputParam = new List<int>(){0,1,1};

        Assert.Equal(list, Program.ThreeSum(inputParam.ToArray()));
    }

    [Fact]
    public void Test3()
    {
        List<List<int>> list = [[0,0,0,]];
        List<int> inputParam = new List<int>(){0,0,0,};
        
        Assert.Equal(list, Program.ThreeSum(inputParam.ToArray()));
    }
}