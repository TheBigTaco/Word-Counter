using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCount.Models;

namespace WordCount.Tests
{
  [TestClass]
  public class RepeatCounterTest
  {
    [TestMethod]
    public void CountRepeats_CountSingleWordRepeats_Int()
    {
      string sentence = "hello";
      string word = "hello";
      int expectedReturn = 1;
      Assert.AreEqual(expectedReturn, RepeatCounter.CountRepeats(sentence, word));
    }
    [TestMethod]
    public void CountRepeats_CountMultiWordRepeats_Int()
    {
      string sentence = "hello hi hows it going hello";
      string word = "hello";
      int expectedReturn = 2;
      Assert.AreEqual(expectedReturn, RepeatCounter.CountRepeats(sentence, word));
    }
    [TestMethod]
    public void CountRepeats_CountMultiWordWithPunctuationRepeats_Int()
    {
      string sentence = "hello, hi. How's it going!?hello... hello %hello$hello@hello";
      string word = "hello";
      int expectedReturn = 6;
      Assert.AreEqual(expectedReturn, RepeatCounter.CountRepeats(sentence, word));
    }
  }
}
