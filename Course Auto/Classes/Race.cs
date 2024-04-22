using Course_Auto.Generators;
using Course_Auto.Models;

namespace Course_Auto.Classes
{
    public class Race
	{
		private int _trackId;
		private Tracks? _currentTrack;
		private List<Cars> _cars = new List<Cars>();
		private List<Tracks> _tracks = new List<Tracks>();
		private List<Drivers> _drivers = new List<Drivers>();
		private GenerateLapTime? _glt;
		private GenerateTracks _gt = new GenerateTracks();
		private GenerateDrivers _gd = new GenerateDrivers();
		private GenerateCars _gc = new GenerateCars();

		public void startRace()
		{
			initialize();
			qualification();
			startingGrid();
			race();
			ranking();
		}

		private void initialize()
		{
			
			_tracks = _gt.getTracks();
			_drivers = _gd.getDrivers();			
			_cars = _gc.getCars();

			Console.WriteLine("Veuillez séléctionner le circuit sur lequel vous souhaitez lancer la course : \n");
			for(int i = 0; i < _tracks.Count; i++)
			{
                Console.WriteLine($"{i + 1}. {_tracks[i].Country} - {_tracks[i].Name}");
            }
            Console.WriteLine("\n");

			bool isChoiceOk = int.TryParse(Console.ReadLine(), out _trackId);

			while(!isChoiceOk || _trackId +1 <= 0 || _trackId >= _tracks.Count + 1)
			{
                Console.WriteLine("Ce choix est incorrect, veuillez recommencer...");
				isChoiceOk = int.TryParse(Console.ReadLine(), out _trackId);
			}

			if(isChoiceOk && _trackId + 1 >= 0 || _trackId <= _tracks.Count + 1)
			{
				_currentTrack = _tracks[(_trackId - 1)];
                Console.WriteLine($"Vous avez choisi : {_currentTrack.Name}. \n");
				Console.WriteLine("Préparation de la qualification... \n");
            }
        }

		private void qualification()
		{
			foreach(Cars car in _cars)
			{
				_glt = new GenerateLapTime(_currentTrack.Laps, _cars);

				car.Driver.QTime = (_glt.time() / 12);
            }
			
		}

		private void startingGrid()
		{
            Console.WriteLine("Grille de départ : ");
			int i = 0;

			_cars = _cars.OrderBy(car => car.Driver?.QTime).ToList();

			foreach (Cars car in _cars)
			{
				i++;
                Console.WriteLine($"{i}. {car.Driver?.FirstName} {car.Driver?.LastName} - {car.Driver?.Team} - {car.Driver?.QTime.ToString(@"mm\:ss\.fff")}");
				Thread.Sleep(1000);
			}
            Console.WriteLine("\n");
        }

		private void race()
		{
			for(int i = 1; i <= _currentTrack.Laps; i++)
			{
				foreach (Cars car in _cars)
				{
					_glt = new GenerateLapTime(_currentTrack.Laps, _cars);

					car.Driver.RTime += (_glt.time() / 12);
				}
			}
		}

		private void ranking()
		{
			_cars.Sort((car1, car2) => car1.Driver.RTime.CompareTo(car2.Driver.RTime));

            Console.WriteLine("Classement d'après course :");

			for(int i = 0; i < _cars.Count; i++)
			{
				Cars car = _cars[i];
                Console.WriteLine($"{i + 1} : Voiture {car.Driver.Number} - {car.Driver.FirstName + " " + car.Driver.LastName} - Temps total : {car.Driver.RTime.ToString(@"hh\:mm\:ss\.fff")}");
				Thread.Sleep(1000);
            }

		}
	}
}
