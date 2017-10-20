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
    public void CountRepeats_CountAmountWordRepeats_Int()
    {
      Assert.AreEqual(1, RepeatCounter.CountRepeats("hello", "hello"));
    }
  }
}
