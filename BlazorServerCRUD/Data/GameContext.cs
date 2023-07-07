namespace BlazorServerCRUD.Data
{
    public class GameContext : DbContext
    {
        public GameContext(DbContextOptions<GameContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Game>().HasData(
                    new Game 
                    {
                        Id = 1,
                        Name = "Red Dead Redemption 2",
                        Publisher = "Rockstar Games",
                        ReleaseDate = new DateTime(2018, 10, 26)
                    },
                    new Game
                    {
                        Id = 2,
                        Name = "Half Life 2",
                        Publisher = "Valve",
                        ReleaseDate = new DateTime(2004, 11, 16)
                    },
                    new Game
                    {
                        Id = 3,
                        Name = "Minecraft",
                        Publisher = "Mojang",
                        ReleaseDate = new DateTime(2011, 11, 18)
                    },
                    new Game
                    {
                        Id = 4,
                        Name = "Roller Champions",
                        Publisher = "Ubisoft Montreal",
                        ReleaseDate = new DateTime(2022, 5, 25)
                    }
                );
        }

        public DbSet<Game> Games => Set<Game>();
    }
}