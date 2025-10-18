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
    public class DetailsModel : PageModel
    {
        private readonly Baciu_Alexia_Lab2.Data.Baciu_Alexia_Lab2Context _context;

        public DetailsModel(Baciu_Alexia_Lab2.Data.Baciu_Alexia_Lab2Context context)
        {
            _context = context;
        }

        public Models.Author Author { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var author = await _context.Authors.FirstOrDefaultAsync(m => m.Id == id);
            if (author == null)
            {
                return NotFound();
            }
            else
            {
                Author = author;
            }
            return Page();
        }
    }
}
