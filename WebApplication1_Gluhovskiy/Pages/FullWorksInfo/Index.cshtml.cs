using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApplication1_Gluhovskiy.Models;

namespace WebApplication1_Gluhovskiy.Pages.FullWorksInfo
{
    public class IndexModel : PageModel
    {
        private readonly WebApplication1_Gluhovskiy.Models.WebApplication1_GluhovskiyContext _context;

        public IndexModel(WebApplication1_Gluhovskiy.Models.WebApplication1_GluhovskiyContext context)
        {
            _context = context;
        }

        public IList<FullWorkData> FullWorkDatas { get; set; }

        public async Task OnGetAsync()
        {
            FullWorkDatas = await _context.FullWorkDatas.ToListAsync();
        }
    }
}