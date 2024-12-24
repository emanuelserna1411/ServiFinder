using ServiFinder.Domain;
using ServiFinder.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiFinder.Services
{
    public class EmployedService : IEmployedServices
    {
        private readonly IRepository<Employed> _repository;

        public EmployedService(IRepository<Employed> repository)
        {
            _repository = repository;
        }

        public IEnumerable<Employed> GetAll()
        {
            return _repository.GetAll();
        }

        public IEnumerable<Employed> GetAllForService(string service)
        {
            return _repository.GetAllForService(service);
        }

        public IEnumerable<Employed> GetAllWithFilters(string services, string location, Categories category, string qualificationOrder)
        {
            
            return _repository.GetAllWithFilters(services, location, category, qualificationOrder);
        }

        public Employed GetById(int id)
        {
            return _repository.GetById(id);
        }
    }
}
