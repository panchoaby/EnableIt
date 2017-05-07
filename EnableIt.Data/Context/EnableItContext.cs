using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnableIt.Domain.Entities;

namespace EnableIt.Data.Context
{
    public class EnableItContext : DbContext
    {
        public EnableItContext()
        {
            //this.Database.Connection.ConnectionString = "connectionString";
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Domain.Entities.Domain> Domains { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Domain.Entities.Application> Applications { get; set; }
    }
}
