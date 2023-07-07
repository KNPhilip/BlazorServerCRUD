namespace BlazorServerCRUD.Services.GameService
{
    public interface IGameService
    {
        List<Game> Games { get; set; }
        Task LoadGames();
        Task<Game> GetGame(int id);
        Task CreateGame(Game game);
        Task UpdateGame(Game game, int id);
        Task DeleteGame(int id);
    }
}