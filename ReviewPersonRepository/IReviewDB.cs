using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewPersonRepository
{
    public interface IReviewDB
    {
        int Create(Review obj);
        Review Get(int id);
        List<Review> GetAll();
        void Update(Review obj);
        void Delete(int id);
    }
}
