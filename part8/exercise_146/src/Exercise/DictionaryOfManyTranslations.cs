using System.Collections.Generic;

namespace Exercise
{
  public class DictionaryOfManyTranslations
  {

    private Dictionary<string, List<string>> bookOfWords;

    public DictionaryOfManyTranslations()
    {
      this.bookOfWords = new Dictionary<string, List<string>>();
    }

    // adds the translation for the word and preserves the old translations
    public void Add(string word, string translation)
    {
      if (!this.bookOfWords.ContainsKey(word))
      {
        this.bookOfWords.Add(word, new List<string>());
      }
      this.bookOfWords[word].Add(translation);
    }

    // returns a list of the translations added for the word. If the word has no translations, the method should return an empty list
    public List<string> Translate(string word)
    {
      if (!this.bookOfWords.ContainsKey(word))
      {
        this.bookOfWords.Add(word, new List<string>());
      }
      {
        return this.bookOfWords[word];
      }
    }

    // removes the word and all its translations from the dictionary. It's probably best to add the translations to an object variable that is of the type Dictionary<string, List<String> >
    public void Remove(string word)
    {
      if (this.bookOfWords.ContainsKey(word))
      {
        this.bookOfWords.Remove(word);
      }
    }
  }
}