using ContactApplication.Models.Entity;
using Microsoft.EntityFrameworkCore;

namespace ContactApplication.Data
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {
        }

        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Phone> Phones { get; set; }       
    }
}
