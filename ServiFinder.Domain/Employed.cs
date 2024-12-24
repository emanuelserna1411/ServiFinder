using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiFinder.Domain
{
    public class Employed
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string ImageProfile { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public double Stars { get; set; }
        public string Phone { get; set; }
        public string Speciality { get; set; }
        public Categories Category { get; set; }
        public List<string> Skills{ get; set; }
    }
}
