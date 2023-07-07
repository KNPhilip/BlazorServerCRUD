namespace BlazorServerCRUD.Services.GameService
{
    public class GameService : IGameService
    {
        private readonly GameContext _context;
        private readonly NavigationManager _navigationManager;

        public GameService(GameContext context, NavigationManager navigationManager)
        {
            _context = context;
            _navigationManager = navigationManager;
            _context.Database.EnsureCreated();
        }

        public List<Game> Games { get; set; } = new List<Game>();

        public async Task CreateGame(Game game)
        {
            _context.Games.Add(game);
            await _context.SaveChangesAsync();
            _navigationManager.NavigateTo("video-games");
        }

        public async Task DeleteGame(int id)
        {
            var game = await _context.Games.FindAsync(id) ?? throw new Exception("Game not found..");
            _context.Games.Remove(game);
            _navigationManager.NavigateTo("video-games");
        }

        public async Task<Game> GetGame(int id)
        {
            return await _context.Games.FindAsync(id) ?? throw new Exception("Game not found..");
        }

        public async Task LoadGames()
        {
            Games = await _context.Games.ToListAsync();
        }

        public async Task UpdateGame(Game game, int id)
        {
            var dbGame = await _context.Games.FindAsync(id) ?? throw new Exception("Game not found..");

            dbGame = game.Adapt<Game>();
            /*dbGame.Name = game.Name;
            dbGame.Publisher = game.Publisher;
            dbGame.ReleaseDate = game.ReleaseDate;*/

            await _context.SaveChangesAsync();
            _navigationManager.NavigateTo("video-games");
        }
    }
}