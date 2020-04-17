namespace Exercise
{
  public class Book : IPackable
  {
    public string author { get; set; }
    public string title { get; set; }
    public int pubyear { get; set; }
    public int weight;

    public Book(string author, string title, int pubyear)
    {
      this.author = author;
      this.title = title;
      this.pubyear = pubyear;
      this.weight = 1;
    }

    public int Weight()
    {
      return this.weight;
    }

    public override string ToString()
    {
      return this.author + ": " + this.title + " (" + this.pubyear + ")";
    }
  }
}