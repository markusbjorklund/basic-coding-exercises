namespace exercise_129
{

  public class Song
  {

    private string artist;
    private string name;
    private int durationInSeconds;

    public Song(string artist, string name, int durationInSeconds)
    {
      this.artist = artist;
      this.name = name;
      this.durationInSeconds = durationInSeconds;
    }

    public override string ToString()
    {
      return this.artist + ": " + this.name + " (" + this.durationInSeconds + " s)";
    }

    // BEGIN SOLUTION
    public override bool Equals(object compared)
    {

      // are the songs equal
      if (this == compared)
      {
        return true;
      }

      // if not equal return false
      if ((compared == null) || !this.GetType().Equals(compared.GetType()))
      {
        return false;
      }

      Song comparedSong = (Song)compared;

      // if the values of the object variables are the same, the objects are equal
      if (this.artist == comparedSong.artist &&
          this.name == comparedSong.name &&
          this.durationInSeconds == comparedSong.durationInSeconds)
      {
        return true;
      }
      // otherwise the objects are not equal
      return false;
    }
    // END SOLUTION
  }
}