// LibraryContext.cs
using System.Configuration;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Library_DTO;
using Microsoft.Identity.Client;

namespace Library_DAL
{
    public class LibraryContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Borrow> Borrows { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["BloggingDatabase"].ConnectionString);
        }
    }
}