using ServiFinder.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiFinder.Repository
{
    public class EmployedRepositoryImpl: IRepository<Employed>
    {
        private ApplicationDataContext _Context = new ApplicationDataContext();

        public IEnumerable<Employed> GetAll()
        {
            return _Context.Employeds;
        }

        public IEnumerable<Employed> GetAllForService(string service)
        {
            return _Context.Employeds.Where(x=>x.Speciality.Contains(service)).ToList();
        }

        public IEnumerable<Employed> GetAllWithFilters(string services, string location, Categories category, string qualificationOrder)
        {
            var data = _Context.Employeds.Where(x => (x.Speciality.ToLower().Contains(services.ToLower()))).Where(x => (x.Address == location) || (x.Category == category || category == Categories.None));

            if (qualificationOrder == "A")
            {
                data = data.OrderBy(x => x.Stars).ToList();
            }
            else if(qualificationOrder == "D")
            {
                data = data.OrderByDescending(x => x.Stars).ToList();
            }
            return data;
        }

        public Employed GetById(int id)
        {
            return _Context.Employeds.Where(x=>x.Id==id).FirstOrDefault()!;
        }
    }
}
