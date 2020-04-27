namespace Exercise
{
  using System.Collections.Generic;
  using System.IO;
  using System;
  public class SaveableDictionary
  {
    private Dictionary<string, string> dict;

    private string file;
    string word { get; set; }
    string translation { get; set; }

    public SaveableDictionary()
    {
      this.dict = new Dictionary<string, string>();
    }

    public SaveableDictionary(string file) : this()
    {
      this.file = file;
    }

    public void Add(string word, string translation)
    {
      this.word = word;
      this.translation = translation;

      if (!this.dict.ContainsKey(word) && !this.dict.ContainsKey(translation))
      {
        this.dict.Add(word, translation);
        this.dict.Add(translation, word);
      }
    }

    public bool Load()
    {
      try
      {
        string[] lines = File.ReadAllLines(this.file);

        foreach (string line in lines)
        {
          string[] parts = line.Split(":");
          if (!this.dict.ContainsKey(parts[0]) && !this.dict.ContainsKey(parts[1]))
          {
            this.dict.Add(parts[0], parts[1]);
            this.dict.Add(parts[1], parts[0]);
          }
        }
        return true;
      }

      catch (Exception e)
      {
        Console.WriteLine(e.Message);
        return false;
      }
    }

    public bool Save()
    {
      try
      {
        StreamWriter writer = new StreamWriter(this.file);

        foreach (var words in this.dict)
        {
          writer.WriteLine(words.Key + ":" + words.Value);
        }
        writer.Close();
        return true;
      }
      catch (Exception)
      {
        return false;
      }
    }

    public string Translate(string word)
    {
      if (this.dict.ContainsKey(word))
      {
        return this.dict[word];
      }
      return null;
    }

    public void Delete(string word)
    {
      foreach (var words in this.dict)
      {
        if (words.Key == word || words.Value == word)
        {
          this.dict.Remove(words.Key);
        }
      }
    }
  }
}