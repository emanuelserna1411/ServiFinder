using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiFinder.Domain
{
    public class UserReport
    {
        public int UserId { get; set; }
        public string Reason { get; set; }
        public string Description { get; set; }
    }
}
