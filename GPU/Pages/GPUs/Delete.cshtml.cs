using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GPU.Data;
using GPU.Models;

namespace GPU.Pages.GPUs
{
    public class DeleteModel : PageModel
    {
        private readonly GPU.Data.GPUContext _context;

        public DeleteModel(GPU.Data.GPUContext context)
        {
            _context = context;
        }

        [BindProperty]
        public GPUDetails GPU { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gpu = await _context.GPU.FirstOrDefaultAsync(m => m.Id == id);

            if (gpu == null)
            {
                return NotFound();
            }
            else
            {
                GPU = gpu;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gpu = await _context.GPU.FindAsync(id);
            if (gpu != null)
            {
                GPU = gpu;
                _context.GPU.Remove(GPU);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
