namespace DL;

public interface IRepo
{
    //Duplicate
    bool isDuplicate(AboutPlayer aboutPlayer);
    bool isDuplicate(Game game);
    bool isDuplicate(Player player);
    bool isDuplicate(Room room);

    //Get All
    List<AboutPlayer> GetAboutPlayers();
    List<Game> GetGames();
    List<Player> GetPlayers();
    List<Room> GetRooms();


    //Get by ID
    AboutPlayer GetAboutPlayersByID(int aboutPlayerID);
    Game GetGameByID(int gameID);
    Player GetPlayerByID(int playerID);
    Room GetRoomByID(int roomID);
    

    //Add 
    AboutPlayer addAboutPlayer(AboutPlayer aboutPlayerToAdd);
    Game addGame(Game gameToAdd);
    Player addPlayer(Player playerToAdd);
    Room addRoom(Room roomToAdd);


    //Delete
    void deleteAboutPlayer(int aboutplayersID);
    void deleteGame(int gameID);
    void deletePlayer(int playerID);
    void deleteRoom(int roomID);
}