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
  }
}