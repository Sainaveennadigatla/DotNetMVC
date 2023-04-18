using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using IdentityApplication.Data;
using IdentityApplication.Models;

namespace IdentityApplication.Pages.Invoice
{
    public class CreateModel : PageModel
    {
        private readonly IdentityApplication.Data.ApplicationDbContext _context;

        public CreateModel(IdentityApplication.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public invoice invoice { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.invoice == null || invoice == null)
            {
                return Page();
            }

            _context.invoice.Add(invoice);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
