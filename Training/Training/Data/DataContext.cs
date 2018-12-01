using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Training.Model;

namespace Training.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {
        }

        public DbSet<KategoriBarang> KategoriBarang { get; set; }
        public DbSet<Barang> Barang { get; set; }

    }
}
