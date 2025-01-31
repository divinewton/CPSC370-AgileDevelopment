namespace CaesarCypher_Tests;

using CaesarCypher;

public class UnitTest1
{
    [Fact]
    public void EncodeTest()
    {
        // Arrange
        string message = "hello";
        int shift = 3;
        string expected = "khoor";

        // Act
        string actual = CaesarCipher.Encode(message, shift);

        // Assert
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    public void DecodeTest()
    {
        // Arrange
        string message = "khoor";
        int shift = 3;
        string expected = "hello";

        // Act
        string actual = CaesarCipher.Decode(message, shift);

        // Assert
        Assert.Equal(expected, actual);
    }
    
    [Theory]
    [InlineData("hello", 2)]
    [InlineData("hello world", 3)]
    [InlineData("Hello World", 4)]
    [InlineData("   what   ", 5)]
    [InlineData("what's up!", 6)]
    [InlineData("", 7)]
    [InlineData("hello world", 0)]
    [InlineData("hello world", -2)]
    [InlineData("hello world", 500)]
    public void EncodeDecodeTest(string message, int shift)
    {
        string encoded = CaesarCipher.Encode(message, shift);
        string decoded = CaesarCipher.Decode(encoded, shift);
        Assert.Equal(message, decoded);
    }
}