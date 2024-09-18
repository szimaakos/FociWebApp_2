using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using FociWebApp.Models;

namespace FociWebApp.Pages
{
    public class UjMeccsFelveteleModel : PageModel
    {
        private readonly FociWebApp.Models.FociDBcontext _context;

        public UjMeccsFelveteleModel(FociWebApp.Models.FociDBcontext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Meccs Meccs { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Meccsek.Add(Meccs);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}