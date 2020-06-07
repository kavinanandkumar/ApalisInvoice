using ApalisInvoice.DAL.Model.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApalisInvoice.DAL.Model
{
   public partial class ApalisInvoiceContext:DbContext
    {
        private readonly EntityConnections entityConnections;
        public ApalisInvoiceContext(EntityConnections entityConnections)
        {
            this.entityConnections = entityConnections;
        }

        public virtual DbSet<AMPS_Config_Users> Users { get; set; }
        public virtual DbSet<AMPS_Config_Company> Companies { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(entityConnections.ConnectionStrings);
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            //builder.Entity<User>(entity => { entity.HasIndex(c => c.QCode).IsUnique(); });
        }
    }
}
