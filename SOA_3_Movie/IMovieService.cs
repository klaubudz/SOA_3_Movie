using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SOA_3_Movie
{
    [ServiceContract]
    public interface IMovieService
    {
        [OperationContract]
        int Create(Movie movie);
        [OperationContract]
        Movie Get(int id);
        [OperationContract]
        List<Movie> GetAll();
        [OperationContract]
        void Update(Movie movie);
        [OperationContract]
        void Delete(int id);
    }
}
