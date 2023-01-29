using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProj.Models.DomainModels
{
    public class Person
    {
        public int PersonId { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public string Mobile { get; set; }
        public string NationalCode { get; set; }
        public string Address { get; set; }
    }
}
