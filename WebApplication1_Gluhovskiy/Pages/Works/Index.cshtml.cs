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
    public class IndexModel : PageModel
    {
        private readonly WebApplication1_Gluhovskiy.Models.WebApplication1_GluhovskiyContext _context;

        public IndexModel(WebApplication1_Gluhovskiy.Models.WebApplication1_GluhovskiyContext context)
        {
            _context = context;
        }

        public IList<Work> Work { get;set; }

        public async Task OnGetAsync()
        {
            Work = await _context.Work.ToListAsync();
        }
    }
}
