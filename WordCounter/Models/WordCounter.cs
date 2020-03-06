using System.Collections.Generic;
using System.Linq;
// using System.Diagnostics;


namespace WordCounter.Models
{
  public class WordCount
  {

    public bool LetterCheck(string input)
    {
      if(!input.Contains("a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"))
      {
        Console.WriteLine("Please make sure your input consists of only letters.");
      }
      else
      {
        return true;
      }
    }
  }
}