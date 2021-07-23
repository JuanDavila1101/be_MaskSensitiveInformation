using System;

namespace be_MaskSensitiveInformation
{
  class MaskSensitiveInformation
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Mask Sensitive Information\n");
      Console.WriteLine("When given a value, mask all but the last four characters.");
      Console.WriteLine("Build a console app that will prompt the user for a secret.");
      Console.WriteLine("When the secret is entered");
      Console.WriteLine("Then print the masked value to the screen\n\n");

      Console.WriteLine("Please enter a word to mask");
      var wordToMask = "";
      wordToMask = Console.ReadLine();

      while (!String.IsNullOrWhiteSpace(wordToMask))
      {
        for(int i = 0; i < wordToMask.Length; i++)
        {
          if (i <= wordToMask.Length - 5)
          {
            Console.Write("*");
          }
          else
          {
            Console.Write(wordToMask[i]);
          }
        }

        Console.WriteLine("\n\nPlease enter a word to mask");
        wordToMask = Console.ReadLine();

      }





    }
  }
}
