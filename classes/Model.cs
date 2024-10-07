public class Anime
{
    public string Name { get; set;}
    public string EnglishName { get; set;}
    public string ReleaseYear { get; set;}
    public string Genre { get; set;}
}

public class Model
{
    public List<Anime> Animes { get; set;}
    public Model()
    {
        Animes = new List<Anime>
        {
            
        };
    }
}