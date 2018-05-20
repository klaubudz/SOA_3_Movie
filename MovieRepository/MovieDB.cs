using LiteDB;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRepository
{
    public class MovieDB : IMovieDB
    {
        private readonly string _connectionString = @"C:\DB\SOA_3";
        private readonly string _collectionName = "movies";

        public int Create(Movie movie)
        {
            using (var db = new LiteDatabase(_connectionString))
            {
                var collection = db.GetCollection<Movie>(_collectionName);

                return collection.Insert(movie);
            }
        }

        public void Delete(int id)
        {
            using (var db = new LiteDatabase(_connectionString))
            {
                var collection = db.GetCollection<Movie>(_collectionName);

                collection.Delete(id);
            }
        }

        public Movie Get(int id)
        {
            using (var db = new LiteDatabase(_connectionString))
            {
                var collection = db.GetCollection<Movie>(_collectionName);

                return collection.FindById(id);
            }
        }

        public List<Movie> GetAll()
        {
            using (var db = new LiteDatabase(_connectionString))
            {
                var collection = db.GetCollection<Movie>(_collectionName);

                return collection.FindAll().ToList();
            }
        }

        public void Update(Movie movie)
        {
            using (var db = new LiteDatabase(_connectionString))
            {
                var collection = db.GetCollection<Movie>(_collectionName);

                collection.Update(movie);
            }
        }
    }
}
