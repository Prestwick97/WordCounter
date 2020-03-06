using System.Collections.Generic;

namespace WordCounter.Models
{
  public class WordCount
  {

    public void LetterCheck(string input)
    {
      if(!input.contain("a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"))
      {
        Console.WriteLine("Please make sure your input consists of only letters.");
      }
    }
  }
}