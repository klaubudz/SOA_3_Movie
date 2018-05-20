using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SOA_3_ReviewPerson
{
    // UWAGA: możesz użyć polecenia „Zmień nazwę” w menu „Refaktoryzuj”, aby zmienić nazwę interfejsu „IService1” w kodzie i pliku konfiguracji.
    [ServiceContract]
    public interface IReviewPersonService
    {
        [OperationContract]
        int CreateReview(Review review);

        [OperationContract]
        Review GetReview(int id);

        [OperationContract]
        List<Review> GetAllReviews();

        [OperationContract]
        void UpdateReview(Review review);

        [OperationContract]
        void DeleteReview(int id);

        //============

        [OperationContract]
        int CreatePerson(Person person);

        [OperationContract]
        Person GetPerson(int id);

        [OperationContract]
        List<Person> GetAllPersons();

        [OperationContract]
        void UpdatePerson(Person person);

        [OperationContract]
        void DeletePerson(int id);

    }
}
