using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;
using Razorpages.Models;

namespace Razorpages.Data
{
    public class RazorDBcontext : DbContext
    {
        public DbSet<PizzaOrder> PizzaOrders { get; set; }
        public RazorDBcontext(DbContextOptions<RazorDBcontext> options)
            :base(options)
        {

        }
    }
}
