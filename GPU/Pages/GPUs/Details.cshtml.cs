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
    public class DetailsModel : PageModel
    {
        private readonly GPU.Data.GPUContext _context;

        public DetailsModel(GPU.Data.GPUContext context)
        {
            _context = context;
        }

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
    }
}
