using AutoMapper;
using SampleProj.Models.Dtos;
using SampleProj.Models.Vms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProj.Services.Mappers
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            PersonDto.ConfigureMapper(this);
            PersonVm.ConfigureMapper(this);
        }
    }
}
