using ServiFinder.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiFinder.Repository
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        IEnumerable<T> GetAllForService(string service);
        IEnumerable<T> GetAllWithFilters(string services, string location, Categories category, string qualificationOrder);

        T GetById(int id);
    }
}
