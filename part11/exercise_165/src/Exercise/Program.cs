namespace Exercise
{
  using System.Collections.Generic;
  using System;
  public class Program
  {
    public static void Main(string[] args)
    {

      SaveableDictionary dictionary = new SaveableDictionary("words.txt");
      bool wasSuccessful = dictionary.Load();

      if (wasSuccessful)
      {
        Console.WriteLine("Successfully loaded the dictionary from file");
      }

      // // // // // Translate all the words in the file both ways
      Console.WriteLine(dictionary.Translate("apina"));
      Console.WriteLine(dictionary.Translate("monkey"));
      Console.WriteLine(dictionary.Translate("beer"));
      Console.WriteLine(dictionary.Translate("olut"));
      Console.WriteLine(dictionary.Translate("below"));
      Console.WriteLine(dictionary.Translate("alla oleva"));

      // // // // // Try adding, translating and removing a word, this should not affect the file
      dictionary.Add("poista", "remove");
      Console.WriteLine(dictionary.Translate("remove"));
      dictionary.Delete("remove");

      // // // // // Save the file
      dictionary.Save();

      // Console.WriteLine(dictionary.Translate("apina"));
      // Console.WriteLine(dictionary.Translate("ohjelmointi"));
      // Console.WriteLine(dictionary.Translate("alla oleva"));

      // SaveableDictionary dictionary = new SaveableDictionary();
      // dictionary.Add("apina", "monkey");
      // dictionary.Add("banaani", "banana");
      // dictionary.Add("apina", "apfe");
      // dictionary.Add("ohjelmointi", "programming");

      // dictionary.Delete("apina");

      // Console.WriteLine(dictionary.Translate("apina"));
      // Console.WriteLine(dictionary.Translate("monkey"));
      // Console.WriteLine(dictionary.Translate("banana"));
      // Console.WriteLine(dictionary.Translate("banaani"));
      // Console.WriteLine(dictionary.Translate("ohjelmointi"));

      // dictionary.Delete("apina");
      // dictionary.Delete("banana");

      // SaveableDictionary dictionary = new SaveableDictionary();
      // dictionary.Add("apina", "monkey");
      // dictionary.Add("banaani", "banana");
      // dictionary.Add("apina", "apfe");

      // Console.WriteLine(dictionary.Translate("apina"));
      // Console.WriteLine(dictionary.Translate("monkey"));
      // Console.WriteLine(dictionary.Translate("ohjelmointi"));
      // Console.WriteLine(dictionary.Translate("banana"));

      if (wasSuccessful)
      {
        Console.WriteLine("Successfully loaded the dictionary from file");
      }
      else
      {
        Console.WriteLine("File not loaded!");
      }
      Console.WriteLine(dictionary.Translate("apina"));
      Console.WriteLine(dictionary.Translate("ohjelmointi"));
      Console.WriteLine(dictionary.Translate("alla oleva"));
    }
  }
}