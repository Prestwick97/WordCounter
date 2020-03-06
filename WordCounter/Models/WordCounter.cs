using System;
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

    public bool CheckWordInstance(string word, string sentence)
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


    public void SentenceWordCount(string word, string sentence)
    {
      List <string> words = new List<string> {};
      string[] sentenceArr = sentence.Split(' ');

      for (var i = 0; i < sentenceArr.Length; i++)
      {
        if (sentenceArr[i] == word)
        {
          words.Add(sentenceArr[i]);
        }
        else{
          words.Add("");
        }
      }
      Console.WriteLine(words.Count());


      // int count = sentenceArr.Count(word);
      // Console.WriteLine(count);
      

    }
    
  }

}    