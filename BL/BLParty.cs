namespace BL;

public class BLParty : IBRepo
{
    private IRepo _dl;

    public BLParty(IRepo repo)
    {
        _dl = repo;
    }

    //Get all
    public List<AboutPlayer> GetAboutPlayers()
    {
        return _dl.GetAboutPlayers();
    }
    public List<Game> GetGames()
    {
        return _dl.GetGames();
    }
    public List<Player> GetPlayers()
    {
        return _dl.GetPlayers();
    }
    public List<Room> GetRooms()
    {
        return _dl.GetRooms();
    }


    //Get by ID
    public AboutPlayer GetAboutPlayersByID(int aboutPlayerID)
    {
        return _dl.GetAboutPlayersByID(aboutPlayerID);
    }
    public Game GetGameByID(int gameID)
    {
        return _dl.GetGameByID(gameID);
    }
    public Player GetPlayerByID(int playerID)
    {
        return _dl.GetPlayerByID(playerID);
    }
    public Room GetRoomByID(int roomID)
    {
        return _dl.GetRoomByID(roomID);
    }


    //Add
    public AboutPlayer addAboutPlayer(AboutPlayer aboutPlayerToAdd)
    {
        if(!_dl.isDuplicate(aboutPlayerToAdd))
        {
            return _dl.addAboutPlayer(aboutPlayerToAdd);
        }
        else throw new DuplicateRecordException("Player already has an about me");
    }
    public Game addGame(Game gameToAdd)
    {
        if(!_dl.isDuplicate(gameToAdd))
        {
            return _dl.addGame(gameToAdd);
        }
        else throw new DuplicateRecordException("Game name already exist");        
    }
    public Player addPlayer(Player playerToAdd)
    {
        if(!_dl.isDuplicate(playerToAdd))
        {
            return _dl.addPlayer(playerToAdd);
        }
        else throw new DuplicateRecordException("Username already exist");       
    }
    public Room addRoom(Room roomToAdd)
    {
        if(!_dl.isDuplicate(roomToAdd))
        {
            return _dl.addRoom(roomToAdd);
        }
        else throw new DuplicateRecordException("Room name already exist");       
    }

    
    //Delete 
    public void deleteAboutPlayer(int aboutplayersID)
    {
        _dl.deleteAboutPlayer(aboutplayersID);
    }
    public void deleteGame(int gameID)
    {
        _dl.deleteGame(gameID);
    }
    public void deletePlayer(int playerID)
    {
        _dl.deletePlayer(playerID);
    }
    public void deleteRoom(int roomID)
    {
        _dl.deleteRoom(roomID);
    }
    
    
}