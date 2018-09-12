using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1_Gluhovskiy.Pages
{
    public class IndexModel : PageModel
    {
        public int CountOfPidors { get; set; }
        public void OnGet()
        {
            CountOfPidors = 100;
        }
    }
}
