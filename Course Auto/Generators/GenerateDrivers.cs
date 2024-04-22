using Course_Auto.Enums;
using Course_Auto.Models;

namespace Course_Auto.Generators
{
    public class GenerateDrivers
    {
        public List<Drivers> getDrivers()
        {
            return new List<Drivers>()
            {
                new Drivers() { Number = 1, FirstName = "Max", LastName = "Verstappen", Team = ETeams.RedBull },
                new Drivers() { Number = 11, FirstName = "Sergio", LastName = "Pérez", Team = ETeams.RedBull },
                new Drivers() { Number = 16, FirstName = "Charles", LastName = "Leclerc", Team = ETeams.Ferrari },
                new Drivers() { Number = 55, FirstName = "Carlos", LastName = "Sainz", Team = ETeams.Ferrari },
                new Drivers() { Number = 4, FirstName = "Lando", LastName = "Norris", Team = ETeams.McLaren },
                new Drivers() { Number = 3, FirstName = "Oscar", LastName = "Piastri", Team = ETeams.McLaren },
                new Drivers() { Number = 44, FirstName = "Lewis", LastName = "Hamilton", Team = ETeams.Mercedes },
                new Drivers() { Number = 77, FirstName = "George", LastName = "Russel", Team = ETeams.Mercedes },
                new Drivers() { Number = 14, FirstName = "Fernando", LastName = "Alonso", Team = ETeams.Aston },
                new Drivers() { Number = 18, FirstName = "Lance", LastName = "Stroll", Team = ETeams.Aston },
                new Drivers() { Number = 47, FirstName = "Daniel", LastName = "Ricciardo", Team = ETeams.VCarb },
                new Drivers() { Number = 47, FirstName = "Yuki", LastName = "Tsunoda", Team = ETeams.VCarb },
                new Drivers() { Number = 9, FirstName = "Kevin", LastName = "Magnussen", Team = ETeams.Haas },
                new Drivers() { Number = 19, FirstName = "Nico", LastName = "Hulkenberg", Team = ETeams.Haas },
                new Drivers() { Number = 63, FirstName = "Alexander", LastName = "Albon", Team = ETeams.Williams },
                new Drivers() { Number = 6, FirstName = "Logan", LastName = "Sargeant", Team = ETeams.Williams },
                new Drivers() { Number = 7, FirstName = "Guanyu", LastName = "Zhou", Team = ETeams.Kick },
                new Drivers() { Number = 99, FirstName = "Valtteri", LastName = "Bottas", Team = ETeams.Kick },
                new Drivers() { Number = 31, FirstName = "Esteban", LastName = "Ocon", Team = ETeams.Alpine },
                new Drivers() { Number = 5, FirstName = "Pierre", LastName = "Gasly", Team = ETeams.Alpine }
            };
        }
    }
}
