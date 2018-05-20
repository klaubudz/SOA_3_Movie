using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB;
using Models;

namespace ReviewPersonRepository
{
    public class PersonDB : IPersonDB
    {
        private readonly string _connectionString = @"C:\DB\SOA_3_1";
        private readonly string _collectionName = "persons";

        public int Create(Person obj)
        {
            using (var db = new LiteDatabase(_connectionString))
            {
                var collection = db.GetCollection<Person>(_collectionName);

                return collection.Insert(obj);
            }
        }

        public void Delete(int id)
        {
            using (var db = new LiteDatabase(_connectionString))
            {
                var collection = db.GetCollection<Person>(_collectionName);

                collection.Delete(id);
            }
        }

        public Person Get(int id)
        {
            using (var db = new LiteDatabase(_connectionString))
            {
                var collection = db.GetCollection<Person>(_collectionName);

                return collection.FindById(id);
            }
        }

        public List<Person> GetAll()
        {
            using (var db = new LiteDatabase(_connectionString))
            {
                var collection = db.GetCollection<Person>(_collectionName);

                return collection.FindAll().ToList();
            }
        }

        public void Update(Person obj)
        {
            using (var db = new LiteDatabase(_connectionString))
            {
                var collection = db.GetCollection<Person>(_collectionName);

                collection.Update(obj);
            }
        }
    }
}
