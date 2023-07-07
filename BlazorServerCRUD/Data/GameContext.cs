namespace BlazorServerCRUD.Data
{
    public class GameContext : DbContext
    {
        public GameContext(DbContextOptions<GameContext> options) : base(options)
        {
            
        }

        public DbSet<Game> Games => Set<Game>();
    }
}