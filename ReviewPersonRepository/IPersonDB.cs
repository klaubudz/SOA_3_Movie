using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewPersonRepository
{
    public interface IPersonDB
    {
        int Create(Person obj);
        Person Get(int id);
        List<Person> GetAll();
        void Update(Person obj);
        void Delete(int id);
    }
}
