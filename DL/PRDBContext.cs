
namespace DL;


public class PRDBContext: DbContext 
{

public PRDBContext():base(){}

public PRDBContext(DbContextOptions options) :base(options){}

public DbSet<Player> Player {get; set;}
public DbSet<Room> Room {get; set;}
public DbSet<AboutPlayer> AboutPlayer {get; set;}
public DbSet<Game> Game {get; set;}

}
