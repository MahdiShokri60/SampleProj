using SampleProj.DataAccessContract.Common;
using SampleProj.Models.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProj.DataAccessContract
{
    public interface IPersonRepository : ICrudRepository<Person>
    {
    }
}
