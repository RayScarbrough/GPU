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
    public class IndexModel : PageModel
    {
        private readonly GPU.Data.GPUContext _context;

        public IndexModel(GPU.Data.GPUContext context)
        {
            _context = context;
        }

        public IList<GPUDetails> GPU { get;set; } = default!;

        public async Task OnGetAsync()
        {
            GPU = await _context.GPU.ToListAsync();
        }
    }
}
