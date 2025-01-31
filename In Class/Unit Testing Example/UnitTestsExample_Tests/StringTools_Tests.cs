using UnitTestingExample;

namespace UnitTestsExample_Tests;

public class StringTools_Tests
{
    
    [Theory]
    [InlineData("Hello World", 2)]
    [InlineData(" ", 0)]
    [InlineData("Hello", 1)]
    [InlineData("I am 12 years old", 5)]
    [InlineData("    Hello World    ", 2)]

    public void CountwordsVariousCorrectCases(string input, int expectedCount)
    {
        int wordsCount = StringTools.CountWords(input);
        
        Assert.Equal(expectedCount, wordsCount);
    }
}