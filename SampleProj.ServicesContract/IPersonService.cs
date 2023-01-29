using SampleProj.Models.Common;
using SampleProj.Models.Dtos;
using SampleProj.Models.Vms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProj.ServicesContract
{
    public interface IPersonService
    {
        Task<Response> CreatePerson(PersonDto dto);
        Task<ListResponse<PersonVm>> GetAll();
    }
}
