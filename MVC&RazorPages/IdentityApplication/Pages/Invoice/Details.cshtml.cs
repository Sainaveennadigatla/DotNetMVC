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
    public class DetailsModel : PageModel
    {
        private readonly IdentityApplication.Data.ApplicationDbContext _context;

        public DetailsModel(IdentityApplication.Data.ApplicationDbContext context)
        {
            _context = context;
        }

      public invoice invoice { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.invoice == null)
            {
                return NotFound();
            }

            var invoice = await _context.invoice.FirstOrDefaultAsync(m => m.InvoiceId == id);
            if (invoice == null)
            {
                return NotFound();
            }
            else 
            {
                invoice = invoice;
            }
            return Page();
        }
    }
}
