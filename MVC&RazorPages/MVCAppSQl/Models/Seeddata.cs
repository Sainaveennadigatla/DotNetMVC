using Microsoft.EntityFrameworkCore;
using MVCAppSQl.Data;

namespace MVCAppSQl.Models
{
    public class Seeddata
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MVCAppSQlContext(serviceProvider.GetRequiredService<DbContextOptions<MVCAppSQlContext>>()))
            {
                if (context.Book.Any())
                {
                    return;
                }
                context.Book.AddRange(
                    new Book { Title = "C# Operator", Mobile = 9658 },
                    new Book { Title = "C# Operator", Mobile = 4681 });
                context.SaveChanges();
            }
        }
    }
}
