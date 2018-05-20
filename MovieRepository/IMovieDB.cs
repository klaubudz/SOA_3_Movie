using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRepository
{
    public interface IMovieDB
    {
        int Create(Movie movie);
        Movie Get(int id);
        List<Movie> GetAll();
        void Update(Movie movie);
        void Delete(int id);
    }
}
