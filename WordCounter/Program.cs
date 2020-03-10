using System;
using WordCounter.Models;
using System.Collections.Generic;

class Program
{

  public static void Main()
  {
   
    Console.WriteLine("Please enter a word");
    string word = Console.ReadLine();
    Console.WriteLine("Please enter a sentence containg instances of the previously entered word");
    string sentence = Console.ReadLine();
    WordCount newCount = new WordCount();
    newCount.LetterCheck(word);
    newCount.LetterCheck(sentence);
    newCount.SentenceWordCount(word, sentence);


  }
}