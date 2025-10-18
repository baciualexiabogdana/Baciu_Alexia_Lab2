using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Baciu_Alexia_Lab2.Data;
using Baciu_Alexia_Lab2.Models;

namespace Baciu_Alexia_Lab2.Pages.Author
{
    public class IndexModel : PageModel
    {
        private readonly Baciu_Alexia_Lab2.Data.Baciu_Alexia_Lab2Context _context;

        public IndexModel(Baciu_Alexia_Lab2.Data.Baciu_Alexia_Lab2Context context)
        {
            _context = context;
        }

        public IList<Models.Author> Author { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Author = await _context.Authors.ToListAsync();
        }
    }
}
