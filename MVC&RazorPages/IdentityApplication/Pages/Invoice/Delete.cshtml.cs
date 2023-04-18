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
    public class DeleteModel : PageModel
    {
        private readonly IdentityApplication.Data.ApplicationDbContext _context;

        public DeleteModel(IdentityApplication.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.invoice == null)
            {
                return NotFound();
            }
            var invoice = await _context.invoice.FindAsync(id);

            if (invoice != null)
            {
                invoice = invoice;
                _context.invoice.Remove(invoice);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
