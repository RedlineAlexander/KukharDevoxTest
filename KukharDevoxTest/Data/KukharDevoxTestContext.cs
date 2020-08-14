using KukharDevoxTest.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KukharDevoxTest.Data
{
    public class KukharDevoxTestContext : DbContext
    {
        KukharDevoxTestContext contexts;
        public KukharDevoxTestContext(KukharDevoxTestContext context)
        {
            contexts = context;
        }
        public DbSet<Projects> Projects { get; set; }

        public DbSet<ActivityType> ActivityType { get; set; }

        public DbSet<Role>  Role { get; set; }
    }
}
