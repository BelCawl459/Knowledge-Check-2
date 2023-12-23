class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("How many records do you want to add? ");
        var numberOfRecords = int.Parse(Console.ReadLine());

        var recordList = new List<ArtistName>();
        for (int i = 0; i < numberOfRecords; i++)
        {
            var zgenre = new Genre();

            Console.WriteLine("Enter the name of the Artist: ");
            zgenre.zArtistName = Console.ReadLine();

            Console.WriteLine("Enter the type of Genre: ");
            zgenre.zGenre = Console.ReadLine();

            recordList.Add(zgenre);
        }

        foreach(ArtistName record in recordList)
        {
            Console.WriteLine(record.ToString());
        }

        Console.WriteLine("\nEnter a Artist Name to get its record count: ");
        string propertyName = Console.ReadLine();
        foreach(ArtistName record in recordList)
        {
            record.ShowProperty(propertyName);
        }

        Console.WriteLine("\nDo you want to see the number of records separated by Artist and Genre? (Y/N)");
        string response = Console.ReadLine();
        if (response.ToLower() == "y")
        {
            var groupedByzArtistName = recordList.GroupBy(x => ((Genre)x).zArtistName).ToList();
            var groupedByzGenre = recordList.GroupBy(x => ((Genre)x).zGenre).ToList();

            Console.WriteLine("Artist Name - Count");
            foreach (var group in groupedByzArtistName)
            {
                Console.WriteLine($"{group.Key} - {group.Count()}");
            }

            Console.WriteLine("Genre - Count");
            foreach (var group in groupedByzGenre)
            {
                Console.WriteLine($"{group.Key} - {group.Count()}");
            }
        }
    }
}