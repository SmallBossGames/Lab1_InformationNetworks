using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApplication1_Gluhovskiy.Models;

namespace WebApplication1_Gluhovskiy.Pages.Works
{
    public class DeleteModel : PageModel
    {
        private readonly WebApplication1_Gluhovskiy.Models.WebApplication1_GluhovskiyContext _context;

        public DeleteModel(WebApplication1_Gluhovskiy.Models.WebApplication1_GluhovskiyContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Work Work { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Work = await _context.Work.FirstOrDefaultAsync(m => m.ID == id);

            if (Work == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Work = await _context.Work.FindAsync(id);

            if (Work != null)
            {
                _context.Work.Remove(Work);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
