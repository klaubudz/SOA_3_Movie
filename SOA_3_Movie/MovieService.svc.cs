using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Models;
using MovieRepository;

namespace SOA_3_Movie
{
    // UWAGA: możesz użyć polecenia „Zmień nazwę” w menu „Refaktoryzuj”, aby zmienić nazwę klasy „Service1” w kodzie, usłudze i pliku konfiguracji.
    // UWAGA: aby uruchomić klienta testowego WCF w celu przetestowania tej usługi, wybierz plik Service1.svc lub Service1.svc.cs w eksploratorze rozwiązań i rozpocznij debugowanie.
    public class MovieService : IMovieService
    {
        private readonly MovieDB _db = new MovieDB();

        public int Create(Movie movie) => _db.Create(movie);

        public void Delete(int id) => _db.Delete(id);

        public Movie Get(int id) => _db.Get(id);

        public List<Movie> GetAll() => _db.GetAll();

        public void Update(Movie movie) => _db.Update(movie);
    }
}
