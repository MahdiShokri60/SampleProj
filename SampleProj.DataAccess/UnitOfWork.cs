using SampleProj.DataAccessContract;
using SampleProj.DataAccessContract.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProj.DataAccess
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SampleDbContext _dbContext;

        public UnitOfWork(SampleDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        private IPersonRepository _personRepository;
        public IPersonRepository PersonRepository =>
            _personRepository ??= new PersonRepository(_dbContext);

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public async Task SaveChanges()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
