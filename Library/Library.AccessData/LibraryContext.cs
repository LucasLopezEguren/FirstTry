using Library.BusinessLogic.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.AccessData
{
    public class LibraryContext:DbContext
    {
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Author> Authors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"SERVER=(localDb)\MsSqlLocalDb;DATABASE=Library2023;Integrated Security=true");
        }
    }
}
