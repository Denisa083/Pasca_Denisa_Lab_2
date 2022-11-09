using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Pasca_Denisa_Lab_2.Models;

namespace Pasca_Denisa_Lab_2.Data
{
    public class Pasca_Denisa_Lab_2Context : DbContext
    {
        public Pasca_Denisa_Lab_2Context (DbContextOptions<Pasca_Denisa_Lab_2Context> options)
            : base(options)
        {
        }

        public DbSet<Pasca_Denisa_Lab_2.Models.Book> Book { get; set; } = default!;

        public DbSet<Pasca_Denisa_Lab_2.Models.Publisher> Publisher { get; set; }

        public DbSet<Pasca_Denisa_Lab_2.Models.Author> Author { get; set; }

        public DbSet<Pasca_Denisa_Lab_2.Models.Category> Category { get; set; }
    }
}
