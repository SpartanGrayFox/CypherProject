using System;

namespace CaesarCipher
{
  class Program
  {
    static void Main(string[] args)
    {
      char[] alphabet = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
      Console.Write("Give me the secret message ");
      string message = Console.ReadLine();
      char[] secretMessage = message.ToCharArray();
      char[] encryptedMessage = new char[secretMessage.Length];
      for (int i = 0; secretMessage.Length > i; i++)
      { char Letters = secretMessage[i];
        int lettersIndex = Array.IndexOf(alphabet, Letters);
        char newLetter = alphabet[(lettersIndex + 3) % 26];
        string encryptedMessageS = String.Join("", encryptedMessage);
        Console.WriteLine(encryptedMessageS);



      }
      

    }
  }
}