using Microsoft.EntityFrameworkCore;
using SampleProj.Models.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProj.DataAccess
{
    public class SampleDbContext : DbContext
    {
        public SampleDbContext(DbContextOptions<SampleDbContext> options) : base(options) { }

        public virtual DbSet<Person> Person { get; set; }
    }
}
