using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProj.DataAccessContract.Common
{
    public interface IUnitOfWork : IDisposable
    {
        IPersonRepository PersonRepository { get; }

        Task SaveChanges();
    }
}
