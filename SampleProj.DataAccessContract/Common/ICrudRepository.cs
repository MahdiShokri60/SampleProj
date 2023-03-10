using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProj.DataAccessContract.Common
{
    public interface ICrudRepository<T>
    {
        Task<List<T>> Get();
        Task<T> GetById(int id);
        void Create(T entity);
        void Update(T entity);
        void Delete(int id);
    }
}
