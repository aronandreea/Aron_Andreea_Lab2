using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Aron_Andreea_Lab2.Models;

namespace Aron_Andreea_Lab2.Data
{
    public class Aron_Andreea_Lab2Context : DbContext
    {
        public Aron_Andreea_Lab2Context (DbContextOptions<Aron_Andreea_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Aron_Andreea_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Aron_Andreea_Lab2.Models.Publisher>? Publisher { get; set; }
    }
}
