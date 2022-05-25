using Library.Models.DbModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Library.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("BookAppConnectionString") { }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Library.Models.DbModels.Library> Libraries { get; set; }

    }
}