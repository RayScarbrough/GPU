using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using GPU.Data;
using GPU.Models;

namespace GPU.Pages.GPUs
{
    public class CreateModel : PageModel
    {
        private readonly GPU.Data.GPUContext _context;

        public CreateModel(GPU.Data.GPUContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public GPUDetails GPU { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.GPU.Add(GPU);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
