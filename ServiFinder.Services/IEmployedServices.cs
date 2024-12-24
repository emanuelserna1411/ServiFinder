using ServiFinder.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiFinder.Services
{
    public interface IEmployedServices
    {
        IEnumerable<Employed> GetAll();
        Employed GetById(int id);

        IEnumerable<Employed> GetAllForService(string service);
        IEnumerable<Employed> GetAllWithFilters(string services, string location, Categories category, string qualificationOrder);
    }
}
