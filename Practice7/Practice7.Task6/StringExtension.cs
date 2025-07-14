using System;
using System.Globalization;
using System.Linq;


namespace Practice7.Task6
{
  public static class StringExtension
  {
    public static bool IsPalindrome(this string text)
    {
      if (string.IsNullOrEmpty(text))
      {
        return true;
      }
      string cleanedStr = text.Replace(" ", "").ToLower();
      return cleanedStr.SequenceEqual(cleanedStr.Reverse());
    }

    public static string ToTitleCase(this string text)
    {
      if (string.IsNullOrEmpty(text)) 
        
        throw new ArgumentNullException("Пустая строка");

      TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
      return textInfo.ToTitleCase(text);

    }
  }
}
