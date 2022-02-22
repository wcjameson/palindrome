using System;
using Palindrome;

namespace PalindromeInterface {

  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Please enter a word.");
      string word = Console.ReadLine();

      PalindromeWord newPalindrome = new PalindromeWord(word);

      Console.WriteLine(newPalindrome.PalindromeChecker());
    }
  }
}