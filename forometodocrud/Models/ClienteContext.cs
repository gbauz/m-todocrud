using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forometodocrud.Models
{
    public class ClienteContext : DbContext
    {
        public DbSet<Cliente> cliente { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-T50DV91\SQLEXPRESS;Initial Catalog=bdmetodocrud;Integrated Security=True;TrustServerCertificate=True");
        }
    }
}
