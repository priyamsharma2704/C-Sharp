using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace validPalindrome;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Assert.True(Program.IsPalindrome("A man, a plan, a canal: Panama"));
    }

    [Fact]
    public void Test2()
    {
        Assert.False(Program.IsPalindrome("race a car"));
    }

    [Fact]
    public void Test3()
    {
        Assert.True(Program.IsPalindrome(""));
    }
}