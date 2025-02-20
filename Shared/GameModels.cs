namespace Frontend.Shared
{
	public class GameRecord
	{
		public Guid Id { get; set; } = new Guid();
		public string PlayerWhite { get; set; } = string.Empty;
		public string PlayerBlack { get; set; } = string.Empty;
		public string Result { get; set; } = string.Empty;
		public DateTime Date { get; set; }
	}
}