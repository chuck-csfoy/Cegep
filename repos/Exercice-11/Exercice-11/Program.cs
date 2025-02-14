using System;

namespace Exercice_11;

internal class Program
{

  /*Question #1*/
  //string title = " <h1 class=\"title\">420-W10string title =-SF</h1>";

  /*Question #2*/
  //string html = "Le HTML(ou HyperText Markup Language) un langage\nbalisé utilisé pour décrire la pages web."

  /*Question #3*/
  //float value = 123.456f;
  //String valueAsString = value.ToString();
  //Console.WriteLine(value.ToString());

  /*Question #4*/
  //string img = "Image_1";
  //int imgLength = img.Length;
  //int strLength = str.Length;
  //char charOf1 = img[img.Length-1];
  //string newStr = str.Replace('X', charOf1);
  //Console.WriteLine(newStr);

  /*Question #5*/
  //string str1 = "< img id = \"apercu\" src = \"images/vignettes/imgX.jpg\" alt = \"apercu\" />";
  //int positionOf1 = img.IndexOf('1');
  //int positionOfX = str.IndexOf('X');
  //string newStr1 = str.Replace(str[positionOfX], img[positionOf1]);
  //Console.WriteLine(newStr1);

  //string newImg = img.Substring(img.IndexOf('_'));
  //string newStr2 = str.Replace("X", newImg);
  //Console.WriteLine(newStr2);
  //string img3 = "image_nom_123";
  //string ReplaceCharStr(string NomImg)
  //{
  //  string str = "< img id = \"apercu\" src = \"images/vignettes/imgX.jpg\" alt = \"apercu\" />";
  //  int i = 0;
  //  int img2Length = NomImg.Length;
  //while (NomImg[i] != (img2.Length - 1))
  //{
  //if (NomImg[i] >= '0' && NomImg[i] <= '9')
  //{
  //if (NomImg[i - 1] == '_')
  //{
  //string newImg2 = NomImg.Substring(NomImg[i]);
  //}
  //}
  //i++;
  //}
  //return;
  //}
  //ReplaceCharStr(str)

  //QUESTION #6
  //public static void Main(String[] args)
  //{
  //  string helloWorld = "HelloWorld@gmail";

  //  SearchCharInString(helloWorld);
  //  Console.WriteLine(SearchCharInString(helloWorld));
  //}
  //public static bool SearchCharInString(string input)
  //{
  //  bool containACharacter = false;
  //  string charToCheck = "@";
  //  if (input.Contains(charToCheck))
  //  {
  //    containACharacter = true;
  //  }
  //  return containACharacter;
  //}
  //OR
  //static void Main(string[] args)
  //{
  //  string helloWorldEmail = "HelloWorld@mail";
  //  char charToCheck = '@';
  //  SearchCharInString(helloWorldEmail, charToCheck);
  //  Console.WriteLine(SearchCharInString(helloWorldEmail, charToCheck));

  //}
  ///*Contains method returns a bool by definition. Dans cette fonction, Contains va nous confirmer la presence du charactère recherché 'c' dans la chaîne de caractères input.*/
  //public static bool SearchCharInString(string input, char c)
  //{
  //  return input.Contains(c);
  //}

  /*QUESTION #7*/
  //public static void Main(String[] args)
  //{
  //  string laDisparitionStr = "La ou nous vivions jadis, il n’y avait ni autos, ni taxis, ni autobus : nous allions parfois, mon cousin m’accompagnait, voir Linda qui habitait dans un canton voisin.";
  //  char charToLookFor = 'a';
  //  CountOccurrenceOfCharInString(laDisparitionStr, charToLookFor);
  //  Console.WriteLine(CountOccurrenceOfCharInString(laDisparitionStr, charToLookFor));
  //}
  //public static int CountOccurrenceOfCharInString(string s1, char c)
  //{
  //  int occurrenceOfCharInString = 0;
  //  for (int index = 0; index < (s1.Length - 1); index++)
  //  {
  //    if (s1[index] == c)
  //    {
  //      occurrenceOfCharInString += 1;
  //    }
  //  }
  //  return occurrenceOfCharInString;
  //}
  /*QUESTION #8*/
  //public static void Main(String[] args)
  //{
  //  string laDisparitionStr = "La ou nous vivions jadis, il n’y avait ni autos, ni taxis, ni autobus : nous allions parfois, mon cousin m’accompagnait, voir Linda qui habitait dans un canton voisin.";
  //  char charToLookFor = 'e';
  //  CountOccurrenceOfCharInString(laDisparitionStr, charToLookFor);
  //  Console.WriteLine(CountOccurrenceOfCharInString(laDisparitionStr, charToLookFor));
  //}
  //public static int CountOccurrenceOfCharInString(string s1, char c)
  //{
  //  int occurrenceOfCharInString = 0;
  //  int index = 0;
  //  if (s1 != null)
  //  {
  //    while (s1.Contains(c))
  //    {
  //      occurrenceOfCharInString += 1;
  //      index++;
  //    }
  //  }
  //  return occurrenceOfCharInString;
  //}
  /*QUESTION #9*/
  //public static void Main(String[] args)
  //{
  //  string input = "HelloWorld";
  //  char symbol = '*';

  //  Console.WriteLine(Encode(input, symbol));
  //}
  //public static string Encode(string strToEncode, char charOperator)
  //{
  //  int index = 0;

  //  while (index < strToEncode.Length)
  //  {
  //    strToEncode = strToEncode.Replace(strToEncode[index], charOperator);
  //    index++;
  //  }
  //  return strToEncode;
  //}
  /*QUESTION #10*/
  //public static void Main(String[] args)
  //{
  //  string inputStr = "   Allo";
  //  char charToRemove = (char) 32;
  //  Console.WriteLine(inputStr, charToRemove);
  //}
  //public static string TrimLeft(string input, char c)
  //{
  //  int index = 0;
  //  while (index < input.Length)
  //  {
  //    if (input[index] == c)
  //    {
  //      index++;
  //    }
  //    else
  //      input += input[index];
  //    index++;
  //  }
  //  return input;
  //}
}

