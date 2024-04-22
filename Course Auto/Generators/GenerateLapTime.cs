using Course_Auto.Models;

namespace Course_Auto.Generators
{
	public class GenerateLapTime
	{
		private int _trackLength { get; set; }
		private List<Cars> _cars;

		public GenerateLapTime(int trackLength, List<Cars> cars)
		{
			_trackLength = trackLength;
			_cars = cars;
		}

		public TimeSpan time()
		{
			Random rnd = new Random();

			foreach(Cars car in _cars)
			{
				double avgSpeed = ((rnd.Next(car.minSpeed, car.maxSpeed + 1)) + rnd.Next(car.minSpeed, car.maxSpeed + 1)) / 2;
				double timeInSeconds = _trackLength / avgSpeed * 3600;

				return TimeSpan.FromSeconds(timeInSeconds);
			}

			return TimeSpan.FromSeconds(60);
		}
	}
}
