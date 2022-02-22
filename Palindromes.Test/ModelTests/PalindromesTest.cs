using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindrome;

namespace Palindrome.Tests
{
  [TestClass]
  public class PalindromeWordTests
  {
    [TestMethod]
    public void PalindromeChecker_ReturnsBool_False()
    {
      PalindromeWord testPalindrome = new PalindromeWord("word");
      Assert.AreEqual(false, testPalindrome.PalindromeChecker());
    }
    [TestMethod]
    public void PalindromeChecker_ReturnTrueIfPalindromeWithSpaces_True()
    {
      PalindromeWord testPalindrome = new PalindromeWord("race car");
      Assert.AreEqual(true, testPalindrome.PalindromeChecker());
    }
    [TestMethod]
    public void PalindromeChecker_ReturnTrueIfPalindrome_True()
    {
      PalindromeWord testPalindrome = new PalindromeWord("racecar");
      Assert.AreEqual(true, testPalindrome.PalindromeChecker());
    }
  }
}