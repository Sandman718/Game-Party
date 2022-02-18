namespace Models;

public class AboutPlayer{
    public int? ID { get; set; }
    public string? GameLibrary { get; set; }
    public string? FavoriteGames { get; set; }
    public int? GamesWon { get; set; }
    public int? GamesLost { get; set; }
    public Player? Player{get;set;}
}