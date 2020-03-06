using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Test
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
    public void CheckWordInstance_VerifyAnyWordInstance_true()
    {
      WordCount newCount = new WordCount();
      bool outcome = newCount.CheckWordInstance("word", "good wrdord");
      Assert.AreEqual(true, outcome);
    }



    // [TestMethod]
    // public int SentenceWordCount_CountWordsInSentence_QuantityInt()
    // {
    //   WordCount newCount = new WordCount();
    //   int count = newCount.SentenceWordCount("cat", "the cat in the cathedral")
    //   Assert.AreEqual(1, count);
    // }
  }
}