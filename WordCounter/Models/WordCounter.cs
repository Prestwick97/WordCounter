using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;


namespace WordCounter.Models
{

  public class WordCount
  {
    public List<string> dictionary = File.ReadAllLines("/Users/Guest/Desktop/Scrabble.Solution/newDictionary.txt").ToList();
 
    public bool LetterCheck(string input)
    {
      input = input.Replace(" ", String.Empty);
      bool outcome = input.All(Char.IsLetter);
      if (outcome == false)
      {
        Console.WriteLine("contains non-letters");
        return false;
      }
      else
      {
        Console.WriteLine("all letters");
        return true;
      }
    }
    
    public bool CheckWord(string word)
    {
      bool englishWord = dictionary.Contains(word);
      return englishWord;
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
        else
        {
          difWords.Add("");
        }
      }
      Console.WriteLine("words in word count:" + words.Count());
      Console.WriteLine("words in dif count:" + difWords.Count());
      return words.Count();
    }
    
  }

}    