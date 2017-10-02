using Microsoft.EntityFrameworkCore;
using WebServiceTest.Entities;
using WebServiceTest.Repositories;

namespace WebServiceTest.Contexts
{
    public class MyContext : DbContext
    {
        public IPersonRepository Persons { get; set; }

        public MyContext() : base()
        {
            this.Persons = new PersonRepository(this);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = @"Server=(localdb)\mssqllocaldb;Database=EFGetStarted.AspNetCore.NewDb;
                Trusted_Connection=True;";

            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().ToTable("Person");
        }
    }
}
