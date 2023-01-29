using AutoMapper;
using SampleProj.Models.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProj.Models.Vms
{
    public class PersonVm
    {
        public int PersonId { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public string Mobile { get; set; }
        public string NationalCode { get; set; }
        public string Address { get; set; }

        public static void ConfigureMapper(Profile mapperProfile)
        {
            mapperProfile.CreateMap<Person, PersonVm>();
        }
    }
}
