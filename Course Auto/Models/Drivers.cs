using Course_Auto.Enums;

namespace Course_Auto.Models
{
	public class Drivers
	{
		public int Number { get; set; }
		public string FirstName { get; set; } = string.Empty;
		public string LastName { get; set; } = string.Empty;
		public ETeams Team { get; set; }
		public TimeSpan QTime { get; set; }
		public TimeSpan RTime { get; set; }
	}
}
