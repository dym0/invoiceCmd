using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace invoiceCmd.Model
{
    class CustomerDBContext : DbContext
    {

        public CustomerDBContext() : base("name=CustomerContext")
        {

        }
        public DbSet<DbCustomer> Customers { get; set; }
    }
}
