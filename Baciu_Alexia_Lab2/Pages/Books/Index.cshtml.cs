using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Baciu_Alexia_Lab2.Data;
using Baciu_Alexia_Lab2.Models;

namespace Baciu_Alexia_Lab2.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly Baciu_Alexia_Lab2.Data.Baciu_Alexia_Lab2Context _context;

        public IndexModel(Baciu_Alexia_Lab2.Data.Baciu_Alexia_Lab2Context context)
        {
            _context = context;
        }

        public IList<Models.Book> Book { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Book = await _context.Book.
                Include(b=>b.Publisher)
                .ToListAsync();
        }
    }
}
