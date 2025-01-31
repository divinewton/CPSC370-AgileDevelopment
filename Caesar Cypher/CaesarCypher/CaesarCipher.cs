namespace CaesarCypher;

public class CaesarCipher
{
    private static readonly char[] Alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
    public static string Encode(string message, int shift)
    {
        char[] messageArray = message.ToCharArray();
        for (int i = 0; i < messageArray.Length; i++)
        {
            if (char.IsLetter(messageArray[i]))
            {
                bool isUpper = char.IsUpper(messageArray[i]);
                int index = Array.IndexOf(Alphabet, char.ToLower(messageArray[i]));
                int newIndex = (index + shift) % Alphabet.Length;
                if (newIndex < 0)
                {
                    newIndex += Alphabet.Length;
                }
                messageArray[i] = isUpper ? char.ToUpper(Alphabet[newIndex]) : Alphabet[newIndex];
            }
        }
        return new string(messageArray);
    }
    
    public static string Decode(string message, int shift)
    {
        char[] messageArray = message.ToCharArray();
        for (int i = 0; i < messageArray.Length; i++)
        {
            if (char.IsLetter(messageArray[i]))
            {
                bool isUpper = char.IsUpper(messageArray[i]);
                int index = Array.IndexOf(Alphabet, char.ToLower(messageArray[i]));
                int newIndex = (index - shift) % Alphabet.Length;
                if (newIndex < 0)
                {
                    newIndex += Alphabet.Length;
                }
                messageArray[i] = isUpper ? char.ToUpper(Alphabet[newIndex]) : Alphabet[newIndex];
            }
        }
        return new string(messageArray);
    }
}