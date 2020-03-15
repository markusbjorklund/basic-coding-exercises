using System;

namespace exercise_113
{
  public class Book
  {
    public string title { get; set; }
    public int pages { get; set; }
    public int year { get; set; }

    public Book(string title, int pages, int year)
    {
      this.title = title;
      this.pages = pages;
      this.year = year;
    }
    public override string ToString()
    {
      return this.title + ", " + this.pages + " pages, " + this.year;
    }

  }
}