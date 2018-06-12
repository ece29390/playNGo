using PlayNGo.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayNGo.Data
{
    public class DataContext:DbContext
    {
        public DataContext() : base("name=PlayNGoConnectionString")
        {
            Database.SetInitializer(new PersonInitializer());
        }

        public DbSet<Person> Persons { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new PersonMap());
            base.OnModelCreating(modelBuilder);
            
        }
    }
}
