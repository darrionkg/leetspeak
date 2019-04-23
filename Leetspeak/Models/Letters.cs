using System;

namespace Leetspeak
{
  class Letters
  {
    public string replaceLetters(string word)
    {
      char[] array = word.ToCharArray();
      for (int i = 0; i < array.Length; i++){
        if(array[i]== 'e' || array[i]== 'E'){
          array[i] = '3';
        }else if(array[i]== 'o' || array[i]== 'O'){
          array[i] = '0';
        }else if (array[i] == 'L' || array[i] == 'l'){
          array[i] = '1';
        }else if (array[i] == 't' || array[i] == 'T'){
          array[i] = '7';
        }else if (array[i] == 's' && array[i-1] != ' '|| array[i] == 'S' && array[i-1] != ' '){
          array[i] = 'z';
        }
      }
        string result = string.Join(" ", array);
        return result;
    }
  }
  class Program
  {
    public static void Main()
    {
      Console.WriteLine("Enter a word or phrase");
      string stringWordToChange = Console.ReadLine();
      Letters newLetter = new Letters();
      string newWord = newLetter.replaceLetters(stringWordToChange);
      Console.WriteLine(newWord);
    }
  }
}
