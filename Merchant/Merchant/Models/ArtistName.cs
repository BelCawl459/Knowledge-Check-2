using System.Reflection;
public class ArtistName
{
    public string zArtistName { get; set; }

    public virtual void ShowProperty(string propertyName)
    {
        if (propertyName == "Artist Name")
        {
            Console.WriteLine(this.zArtistName);
        }
    }

    public override string ToString()
    {
        return $"Artist Name: {this.zArtistName}";
    }
}