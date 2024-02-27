namespace validAnagram;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Assert.True(Program.IsAnagram("anagram", "nagaram"));
    }

    [Fact]
    public void Test2()
    {
        Assert.False(Program.IsAnagram("cat", "rat"));
    }

    [Fact]
    public void Test3()
    {
        Assert.False(Program.IsAnagram("ab", "a"));
    }
}