using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorfism
{
    class Context: DbContext 
    {
        public Context(DbContextOptions<Context> dbContextOptions): base(dbContextOptions)
        {

        }

        public DbSet<A1> A1s { get; set; }
    }
    class A1
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
