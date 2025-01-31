namespace UnitTestingExample;

public class StringTools
{
    public static int CountWords(string words)
    {
        if (string.IsNullOrWhiteSpace(words))
            return 0;
        
        words = words.Trim();
        string[] wordsArray = words.Split(' ');
        return wordsArray.Length;
    }
}