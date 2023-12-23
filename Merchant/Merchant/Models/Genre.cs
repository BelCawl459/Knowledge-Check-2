using System.Reflection;

public class Genre : ArtistName
{
    public string zGenre { get; set; }

    public override void ShowProperty(string propertyName)
    {
        base.ShowProperty(propertyName);
        if (propertyName == "Genre")
        {
            Console.WriteLine(this.zGenre);
        }
    }

    public override string ToString()
    {
        return base.ToString() + $", Genre: {this.zGenre}";
    }
}