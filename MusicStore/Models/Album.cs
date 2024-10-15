namespace MusicStore.Models
{
	public class Album
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public List<string> Reviews { get; set; }
	}
}
