using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCAppSQl.Models;

namespace MVCAppSQl.Data
{
    public class MVCAppSQlContext : DbContext
    {
        public MVCAppSQlContext (DbContextOptions<MVCAppSQlContext> options)
            : base(options)
        {
        }

        public DbSet<MVCAppSQl.Models.Book> Book { get; set; } = default!;
    }
}
