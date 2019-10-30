using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CIS174_TestCoreApp.Entities
{
    public class Person
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Birthdate { get; set; }

        [StringLength(10)]
        public string City { get; set; }

        [StringLength(2)]
        public string State { get; set; }

        public ICollection<Accomplishment> Accomplishments { get; set; }

    }
}
