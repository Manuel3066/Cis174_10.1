using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CIS174_TestCoreApp.Entities
{
    public class Accomplishment
    {
        public int Id { get; set; }
    
        public int PersonId { get; set; }

        public string Name { get; set; }

        public string DateOfAccomplishement { get; set; }
    }
}
