using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sql
{
    public class PhoneContext:DbContext
    { 
        public DbSet<product> Products { get; set; }
    }
}
