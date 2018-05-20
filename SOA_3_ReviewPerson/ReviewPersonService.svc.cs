using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Models;
using ReviewPersonRepository;

namespace SOA_3_ReviewPerson
{
    // UWAGA: aby uruchomić klienta testowego WCF w celu przetestowania tej usługi, wybierz plik Service1.svc lub Service1.svc.cs w eksploratorze rozwiązań i rozpocznij debugowanie.
    public class ReviewPersonService : IReviewPersonService
    {
        private readonly ReviewDB _reviewdb = new ReviewDB();
        private readonly PersonDB _persondb = new PersonDB();

        #region reviews

        public int CreateReview(Review review) => _reviewdb.Create(review);

        public void DeleteReview(int id) => _reviewdb.Delete(id);

        public List<Review> GetAllReviews() => _reviewdb.GetAll();

        public Review GetReview(int id) => _reviewdb.Get(id);

        public void UpdateReview(Review review) => _reviewdb.Update(review);

        #endregion

        //========

        #region person

        public int CreatePerson(Person person) => _persondb.Create(person);

        public void DeletePerson(int id) => _persondb.Delete(id);

        public List<Person> GetAllPersons() => _persondb.GetAll();

        public Person GetPerson(int id) => _persondb.Get(id);

        public void UpdatePerson(Person person) => _persondb.Update(person);

        #endregion
    }
}
