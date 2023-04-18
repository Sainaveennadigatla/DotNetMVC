using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using IdentityApplication.Data;
using IdentityApplication.Models;

namespace IdentityApplication.Pages.Invoice
{
    public class IndexModel : PageModel
    {
        private readonly IdentityApplication.Data.ApplicationDbContext _context;

        public IndexModel(IdentityApplication.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<invoice> invoice { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.invoice != null)
            {
                invoice = await _context.invoice.ToListAsync();
            }
        }
    }
}
