namespace Models;

public class Room{
    
    public int? ID { get; set; }
    public string? RoomName { get; set; }
    public int? RoomCode { get; set; }
    public int? PlayerCount { get; set; }
    public List<Player>?  Players {get; set;}
}