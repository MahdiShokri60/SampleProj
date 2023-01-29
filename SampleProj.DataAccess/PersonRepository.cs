using Microsoft.EntityFrameworkCore;
using SampleProj.DataAccessContract;
using SampleProj.DataAccessContract.Common;
using SampleProj.Models.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProj.DataAccess
{
    public class PersonRepository : IPersonRepository
    {
        private readonly SampleDbContext _dbContext;

        public PersonRepository(SampleDbContext dbContext = null)
        {
            _dbContext = dbContext;
        }

        public void Create(Person entity)
        {
            _dbContext.Add(entity);
        }

        public void Delete(int id)
        {
            var person = GetById(id);
            _dbContext.Remove(person);
        }

        public async Task<List<Person>> Get()
        {
            return await _dbContext.Person.ToListAsync();
        }

        public async Task<Person> GetById(int id)
        {
            return await _dbContext.Person.FindAsync(id);
        }

        public void Update(Person entity)
        {
            _dbContext.Update(entity);
        }        
    }
}
