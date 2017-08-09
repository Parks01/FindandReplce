using System;
using System.Collections.Generic;

namespace FindAndReplace.Models
{
    public class FindReplace
    {
      private static string _mainArticle;
      private string _tobeReplace;
      private string _newWord;

      public FindReplace (string tobeReplace, string newWord)
      {
        _tobeReplace = tobeReplace;
        _newWord = newWord;
      }
      public static void SetMainArticle(string mainArticle)
      {
        _mainArticle = mainArticle;
      }
      public static string GetMainArticle()
      {
        return _mainArticle;
      }
      public string FindAndReplace()
      {
        string [] articleArr = _mainArticle.Split(' ');
        for (int i = 0; i < articleArr.Length; i++)
        {
          if (articleArr[i] == _tobeReplace)
          {
            articleArr[i] = _newWord;
          }
        }
        string result = String.Join(" ", articleArr);
        return result;
      }
    }
}
