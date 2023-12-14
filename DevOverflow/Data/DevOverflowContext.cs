using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DevOverflow.Entity;

namespace DevOverflow.Data
{
    public class DevOverflowContext : DbContext
    {
        public DevOverflowContext (DbContextOptions<DevOverflowContext> options)
            : base(options)
        {
        }

        public DbSet<DevOverflow.Entity.Answer> Answer { get; set; } = default!;

        public DbSet<DevOverflow.Entity.Question>? Question { get; set; }
    }
}
