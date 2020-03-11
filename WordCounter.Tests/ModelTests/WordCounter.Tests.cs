using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Tests
{

  [TestClass]
  public class WordCountTests
  {

    [TestMethod]
    public void LetterCheck_RecieveOnlyLetters_true()
    {
      WordCount newCount = new WordCount();
      bool outcome = newCount.LetterCheck("word");
      Assert.AreEqual(true, outcome);
    }

    [TestMethod]
    public void LetterCheck_RecieveOnlyLetters_false()
    {
      WordCount newCount = new WordCount();
      bool outcome = newCount.LetterCheck("w3ord");
      Assert.AreEqual(false, outcome);
    }

    [TestMethod]
    public void CheckWord_CheckWordInEnglishDictionary_true()
    {
      WordCount newCount = new WordCount();
      bool check = newCount.CheckWord("safe");
      Assert.AreEqual(true, check);
    }

        [TestMethod]
    public void CheckWord_CheckWordInEnglishDictionary_false()
    {
      WordCount newCount = new WordCount();
      bool check = newCount.CheckWord("safeasdfasf");
      Assert.AreEqual(false, check);
    }

    [TestMethod]
    public void CheckWordInstance_VerifyAnyWordInstance_true()
    {
      WordCount newCount = new WordCount();
      bool outcome = newCount.CheckWordInstance("word", "good word");
      Assert.AreEqual(true, outcome);
    }

    [TestMethod]
    public void CheckWordInstance_VerifyAnyWordInstance_false()
    {
      WordCount newCount = new WordCount();
      bool outcome = newCount.CheckWordInstance("word", "good good");
      Assert.AreEqual(false, outcome);
    }


    [TestMethod]
    public void SentenceWordCount_CountWordsInSentenceNotIncludingNests_QuantityInt()
    {
      WordCount newCount = new WordCount();
      int count = newCount.SentenceWordCount("cat", "the cat in the cathedral");
      Assert.AreEqual(1, count);
    }
    
    [TestMethod]
    public void SentenceWordCount_CountWordsInSentence_QuantityInt()
    {
      WordCount newCount = new WordCount();
      int count = newCount.SentenceWordCount("cat", "the cat thought about another cat in the cathedral for every cat");
      Assert.AreEqual(3, count);
    }

  }
}