using UnitTestingExample;

namespace UnitTestsExample_Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Assert.Equal(6, Calculator.Add(2, 4));
    }

    [Theory]
    [InlineData(2, 1, 3)]
    [InlineData(-1, -1, -2)]
    public void Test2(int x, int y, int sum)
    {
        Assert.Equal(sum, Calculator.Add(x, y));
    }
}