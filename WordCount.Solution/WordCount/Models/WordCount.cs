using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace WordCount.Models
{
  public class RepeatCounter
  {
    private static char[] _splitters = {' ', ',','.','?','/','!','-','$','%','@'};
    public static int CountRepeats(string sentence, string word)
    {
      int counter = 0;
      string[] stringArray = sentence.Split(_splitters);
      foreach(string check in stringArray)
      {
        if(check == word)
        {
          counter++;
        }
      }
      return counter;
    }
  }
}
