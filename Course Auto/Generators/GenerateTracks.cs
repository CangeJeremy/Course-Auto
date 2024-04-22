using Course_Auto.Models;

namespace Course_Auto.Generators
{
    public class GenerateTracks
    {
        public List<Tracks> getTracks()
        {
            return new List<Tracks>()
            {
                new Tracks("Bahreïn", "Circuit International de Bahreïn", 5.412, 57),
                new Tracks("Arabie Saoudite", "Circuit Urbain de Jeddah", 6.175, 50),
                new Tracks("Australie", "Circuit Albert Park", 5.303, 58),
                new Tracks("Japon", "Circuit de Suzuka", 5.807, 53),
                new Tracks("Chine", "Circuit International de Shanghai", 5.451, 56),
                new Tracks("États-Unis", "Autodrome International de Miami", 5.412, 55),
                new Tracks("Italie", "Circuit d'Imola", 4.909, 63),
                new Tracks("Monaco", "Circuit de Monaco", 3.337, 78),
                new Tracks("Canada", "Circuit Gilles Villeneuve", 4.361, 70),
                new Tracks("Espagne", "Circuit de Barcelone-Catalogne", 4.675, 66),
                new Tracks("Autriche", "Red Bull Ring", 4.318, 71),
                new Tracks("Royaume-Uni", "Circuit de Silverstone", 5.891, 52),
                new Tracks("Hongrie", "Hungaroring", 4.381, 70),
                new Tracks("Belgique", "Circuit de Spa-Francorchamps", 7.004, 44),
                new Tracks("Pays-Bas", "Circuit de Zandvoort", 4.259, 72),
                new Tracks("Italie", "Autodromo Nazionale di Monza", 5.793, 53),
                new Tracks("Azerbaïdjan", "Circuit Urbain de Bakou", 6.003, 51),
                new Tracks("Singapour", "Circuit Urbain de Marina Bay", 5.063, 61),
                new Tracks("États-Unis", "Circuit des Amériques", 5.513, 56),
                new Tracks("Mexique", "Autódromo Hermanos Rodríguez", 4.304, 71),
                new Tracks("Brésil", "Autódromo José Carlos Pace", 4.309, 71),
                new Tracks("États-Unis", "Circuit Urbain de Las Vegas", 6.201, 50),
                new Tracks("Qatar", "Circuit International de Losail", 5.380, 57),
                new Tracks("Émirats Arabes Unis", "Circuit de Yas Marina", 5.554, 55)
            };
        }
    }
}
