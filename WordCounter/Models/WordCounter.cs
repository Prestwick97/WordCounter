using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
// using System.Diagnostics;


namespace WordCounter.Models
{

  public class WordCount
  {
    public bool LetterCheck(string input)
    {
      bool outcome = Regex.IsMatch(input, @"^[a-zA-Z]+$");
      if (outcome == false)
      {
        return false;
      }
      else
      {
        return true;
      }
    }
  }
}    