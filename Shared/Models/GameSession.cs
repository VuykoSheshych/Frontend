namespace Frontend.Shared.Models;
public class GameSession
{
	public string Id { get; set; } = string.Empty;
	public string PlayerWhite { get; set; } = string.Empty;
	public string PlayerBlack { get; set; } = string.Empty;
	public List<Move> Moves { get; set; } = [];
	public string CurrentFen { get; set; } = "rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 1";
	public string Result { get; set; } = "active";
	public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
