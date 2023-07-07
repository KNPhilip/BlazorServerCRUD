namespace BlazorServerCRUD.Services.GameService
{
    public interface IGameService
    {
        List<Game> Games { get; set; }
        Task LoadGames();
    }
}