using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;


namespace WordCounter.Models
{

  public class WordCount
  {
    // public string InputWord {get; set;}
    // public string InputSentence {get; set;}
 

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

    public bool CheckWordInstance(string word string sentence)
    {
      if (sentence.Contains(word))
      {
        return true;
      }
      else
      {
        return false;
      }
    }

    public int SentenceWordCount(string word, string sentence)
    {
      

    }
    
  }

}    