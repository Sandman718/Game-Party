using Microsoft.EntityFrameworkCore;
using Models;
namespace DL;

public class DBParty : IRepo
{
    private PRDBContext _context;
    public DBParty(PRDBContext context)
    {
        _context = context;
    }


    //Check for Duplicates
    public bool isDuplicate(AboutPlayer aboutPlayer)
    {
        AboutPlayer? dupe = _context.AboutPlayer.FirstOrDefault(a => a.Player == aboutPlayer.Player);
        return dupe != null;
    }
    public bool isDuplicate(Game game)
    {
        Game? dupe = _context.Game.FirstOrDefault(g => g.GameName == game.GameName);
        return dupe != null;
    }
    public bool isDuplicate(Player player)
    {
        Player? dupe = _context.Player.FirstOrDefault(p => p.Username == player.Username);
        return dupe != null;
    }
    public bool isDuplicate(Room room)
    {
        Room? dupe = _context.Room.FirstOrDefault(r => r.RoomName == room.RoomName);
        return dupe != null;
    }

    
    //Get Alls
    public List<AboutPlayer> GetAboutPlayers()
    {
        return _context.AboutPlayer.Select(a => a).ToList();
    }
    public List<Game> GetGames()
    {
        return _context.Game.Select(g => g).ToList();
    }
    public List<Player> GetPlayers()
    {
        return _context.Player.Select(p => p).ToList();        
    }
    public List<Room> GetRooms()
    {
        return _context.Room.Select(r => r).ToList();
    }


    //GetByID
    public AboutPlayer GetAboutPlayersByID(int aboutPlayerID)
    {
        return _context.AboutPlayer.FirstOrDefault(a => a.ID == aboutPlayerID)!;
    }
    public Game GetGameByID(int gameID)
    {
        return _context.Game.FirstOrDefault(g => g.ID == gameID)!;
    }
    public Player GetPlayerByID(int playerID)
    {
        return _context.Player.FirstOrDefault(p => p.ID == playerID)!;
    }
    public Room GetRoomByID(int roomID)
    {
        return _context.Room.FirstOrDefault(r => r.ID == roomID)!;
    }


    //Add 
    public AboutPlayer addAboutPlayer(AboutPlayer aboutPlayerToAdd)
    {
        _context.Add(aboutPlayerToAdd);
        _context.SaveChanges();
        _context.ChangeTracker.Clear();
        return aboutPlayerToAdd;
    }
    public Game addGame(Game gameToAdd)
    {
        _context.Add(gameToAdd);
        _context.SaveChanges();
        _context.ChangeTracker.Clear();
        return gameToAdd;
    }
    public Player addPlayer(Player playerToAdd)
    {
        _context.Add(playerToAdd);
        _context.SaveChanges();
        _context.ChangeTracker.Clear();
        return playerToAdd;
    }
    public Room addRoom(Room roomToAdd)
    {
        _context.Add(roomToAdd);
        _context.SaveChanges();
        _context.ChangeTracker.Clear();
        return roomToAdd;
    }


    //Delete 
    public void deleteAboutPlayer(int aboutplayersID)
    {
        AboutPlayer aboutPlayer = GetAboutPlayersByID(aboutplayersID);
        _context.Remove(aboutPlayer);
        _context.SaveChanges();
        _context.ChangeTracker.Clear();
    }
    public void deleteGame(int gameID)
    {
        Game game = GetGameByID(gameID);
        _context.Remove(game);
        _context.SaveChanges();
        _context.ChangeTracker.Clear();
    }
    public void deletePlayer(int playerID)
    {
        Player player = GetPlayerByID(playerID);
        _context.Remove(player);
        _context.SaveChanges();
        _context.ChangeTracker.Clear();
    }
    public void deleteRoom(int roomID)
    {
        Room room = GetRoomByID(roomID);
        _context.Remove(room);
        _context.SaveChanges();
        _context.ChangeTracker.Clear();
    }


}