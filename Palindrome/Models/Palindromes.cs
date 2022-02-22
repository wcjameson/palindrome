using System;
using System.Linq;
namespace Palindrome
{
  public class PalindromeWord
  {

    public string _word;

    public PalindromeWord(string word)
    {
      _word = word;
    }

    public bool PalindromeChecker()
    {
      string[] words = _word.Split(' ');
      string wordArray = "";
      for (int i = 0; i < words.Length; i++)
      {
        wordArray += words[i];
      }
      char[] newArray = Enumerable.Reverse(wordArray).ToArray();
      bool isEqual = Enumerable.SequenceEqual(wordArray, newArray);
      if (isEqual)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }
}