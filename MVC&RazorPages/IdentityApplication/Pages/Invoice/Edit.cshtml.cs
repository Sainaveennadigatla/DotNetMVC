using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using IdentityApplication.Data;
using IdentityApplication.Models;

namespace IdentityApplication.Pages.Invoice
{
    public class EditModel : PageModel
    {
        private readonly IdentityApplication.Data.ApplicationDbContext _context;

        public EditModel(IdentityApplication.Data.ApplicationDbContext context)
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

            var invoice =  await _context.invoice.FirstOrDefaultAsync(m => m.InvoiceId == id);
            if (invoice == null)
            {
                return NotFound();
            }
            invoice = invoice;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(invoice).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!invoiceExists(invoice.InvoiceId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool invoiceExists(int id)
        {
          return (_context.invoice?.Any(e => e.InvoiceId == id)).GetValueOrDefault();
        }
    }
}
