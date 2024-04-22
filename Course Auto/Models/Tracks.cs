namespace Course_Auto.Models
{
	public class Tracks
	{
		public string Name { get; set; } = string.Empty;
		public double Length { get; set; }
		public string Country { get; set; }
		public int Laps { get; set; }

		public Tracks(string c, string n, double l, int laps)
		{
			Country = c;
			Name = n;
			Length = l;
			Laps = laps;
		}
	}
}
