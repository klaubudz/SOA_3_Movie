using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB;
using Models;

namespace ReviewPersonRepository
{
    public class ReviewDB : IReviewDB
    {
        private readonly string _connectionString = @"C:\DB\SOA_3_1";
        private readonly string _collectionName = "reviews";

        public int Create(Review obj)
        {
            using (var db = new LiteDatabase(_connectionString))
            {
                var collection = db.GetCollection<Review>(_collectionName);

                return collection.Insert(obj);
            }
        }

        public void Delete(int id)
        {
            using (var db = new LiteDatabase(_connectionString))
            {
                var collection = db.GetCollection<Review>(_collectionName);

                collection.Delete(id);
            }
        }

        public Review Get(int id)
        {
            using (var db = new LiteDatabase(_connectionString))
            {
                var collection = db.GetCollection<Review>(_collectionName);

                return collection.FindById(id);
            }
        }

        public List<Review> GetAll()
        {
            using (var db = new LiteDatabase(_connectionString))
            {
                var collection = db.GetCollection<Review>(_collectionName);

                return collection.FindAll().ToList();
            }
        }

        public void Update(Review obj)
        {
            using (var db = new LiteDatabase(_connectionString))
            {
                var collection = db.GetCollection<Review>(_collectionName);

                collection.Update(obj);
            }
        }
    }
}
