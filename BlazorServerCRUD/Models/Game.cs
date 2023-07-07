namespace BlazorServerCRUD.Models
{
    public class Game
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Publisher { get; set; }
        public required DateTime ReleaseDate { get; set; }
    }
}