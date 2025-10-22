using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Baciu_Alexia_Lab2.Models;

namespace Baciu_Alexia_Lab2.Data
{
    public class Baciu_Alexia_Lab2Context : DbContext
    {
        public Baciu_Alexia_Lab2Context (DbContextOptions<Baciu_Alexia_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Baciu_Alexia_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Baciu_Alexia_Lab2.Models.Author> Authors { get; set; } = default!;
        public DbSet<Baciu_Alexia_Lab2.Models.Publisher> Publisher { get; set; } = default!;
        public DbSet<Baciu_Alexia_Lab2.Models.Category> Category { get; set; } = default!;
    }
}
