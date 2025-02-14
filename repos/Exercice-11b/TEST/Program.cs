using System;

namespace Exercice_11b
{
  internal class Program
  {
    /*Question #4*/
    //static void Main(string[] args)
    //{
    //  String inputStr = "Hello Wonderful World";


    //  Console.WriteLine(CountVowelInString(inputStr));
    //}
    //static public int CountVowelInString(string S1)
    //{
    //  int vowelCount = 0;
    //  int index = 0;
    //  int S1Length = S1.Length;
    //  while (index < S1Length)
    //  {
    //    if (S1[index] == 'a' || S1[index] == 'e' || S1[index] == 'i' || S1[index] == 'o' || S1[index] == 'u' ||
    //     S1[index] == 'A' || S1[index] == 'E' || S1[index] == 'I' || S1[index] == 'O' || S1[index] == 'U')
    //    {
    //      vowelCount += 1;
    //    }
    //    index++;
    //  }
    //  return vowelCount;
    //}
    /*Question #5*/
    //static void Main(string[] args)
    //{
    //  string inputStr = "ppoulin_1234567";

    //  Console.WriteLine(SearchSubstringInStr(inputStr));
    //}
    //static public string SearchSubstringInStr(string strToSearch)
    //{
    //  int strToSearchLength = strToSearch.Length;
    //  int index = strToSearchLength-7;
    //  int strSubLength = 7;

    //  return strToSearch = strToSearch.Substring(index, strSubLength);
    //}
    /*Question #6*/
    static void Main(string[] args)
    {
      string inputStr = "ajd;kjSJDASJKD";
      string validateInStr = "DAS";

      Console.WriteLine(ifContainsInStr(inputStr, validateInStr));
    }
    static public bool ifContainsInStr(string strToSearch, string subStr)
    {

      bool isInString = false;
      int strToSearchLength = strToSearch.Length;
      int subStrLength = subStr.Length;
      int indexToSearch = 0;
      int indexSub = 0;
      if (subStr == "")
      {
        isInString = true;
        return isInString;
      }
      while (indexToSearch < strToSearchLength)
      {
        if (strToSearch[indexToSearch] == subStr[indexSub])
        {
          if (indexSub == subStrLength - 1)
          {
            isInString = true;
            break;
          }
          indexSub++;
        }
        indexToSearch++;
      }
      return isInString;
    }
    /*OR*/
    //static public bool ifContainsInStr(string strToSearch, string subStr)
    //{
    //  return strToSearch.Contains(subStr);
    //}
  }
}
