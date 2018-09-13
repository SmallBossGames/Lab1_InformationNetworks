using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApplication1_Gluhovskiy.Models;

namespace WebApplication1_Gluhovskiy.Pages.Genres
{
    public class DetailsModel : PageModel
    {
        private readonly WebApplication1_Gluhovskiy.Models.WebApplication1_GluhovskiyContext _context;

        public DetailsModel(WebApplication1_Gluhovskiy.Models.WebApplication1_GluhovskiyContext context)
        {
            _context = context;
        }

        public Genre Genre { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Genre = await _context.Genres.FirstOrDefaultAsync(m => m.GenreID == id);

            if (Genre == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
