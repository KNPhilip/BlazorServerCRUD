namespace BlazorServerCRUD.Services.GameService
{
    public class GameService : IGameService
    {
        private readonly GameContext _context;

        public GameService(GameContext context)
        {
            _context = context;
            _context.Database.EnsureCreated();
        }

        public List<Game> Games { get; set; } = new List<Game>();

        public async Task LoadGames()
        {
            Games = await _context.Games.ToListAsync();
        }
    }
}