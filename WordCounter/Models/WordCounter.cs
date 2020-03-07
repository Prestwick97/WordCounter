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


    public int SentenceWordCount(string word, string sentence)
    {
      List <string> difWords = new List<string> {};
      List <string> words = new List<string> {};
      string[] sentenceArr = sentence.Split(' ');
      string[] wordArr = word.Split(' ');

      for (int i = 0; i < sentenceArr.Length; i++)
      {
        if (sentenceArr[i].Equals(wordArr[0]))
        {
          words.Add(sentenceArr[i]);
        }
        else{
          difWords.Add("");
        }
      }
      Console.WriteLine("words in word count:" + words.Count());
      Console.WriteLine("words in dif count:" + difWords.Count());
      return words.Count();


      // int count = sentenceArr.Count(word);
      // Console.WriteLine(count);
      

    }
    
  }

}    
// public int SentenceWordCount(string word, string sentence)
//     {
//       List <string> words = new List<string> {};
//       string[] sentenceArr = sentence.Split(' ');

//       for (int i = 0; i < sentenceArr.Length; i++)
//       {
//         if (sentenceArr[i] == word)
//         {
//           words.Add(sentenceArr[i]);
//         }
//         else{
//           words.Add("");
//           return words.Count();
//         }
//       }
//       Console.WriteLine(words.Count());
//       Console.WriteLine(sentenceArr.ToString());
//       return words.Count();


//       // int count = sentenceArr.Count(word);
//       // Console.WriteLine(count);
      

//     }