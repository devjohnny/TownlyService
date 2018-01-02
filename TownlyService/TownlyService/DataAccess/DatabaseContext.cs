using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using TownlyService.Domain;

namespace TownlyService.DataAccess
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("TownlyDatabaseContext")
        {
        }

        public DbSet<Event> Events { get; set; }
        public DbSet<Question> Questions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}