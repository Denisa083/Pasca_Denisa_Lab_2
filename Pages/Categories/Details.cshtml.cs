using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Pasca_Denisa_Lab_2.Data;
using Pasca_Denisa_Lab_2.Models;

namespace Pasca_Denisa_Lab_2.Pages.Categories
{
    public class DetailsModel : PageModel
    {
        private readonly Pasca_Denisa_Lab_2.Data.Pasca_Denisa_Lab_2Context _context;

        public DetailsModel(Pasca_Denisa_Lab_2.Data.Pasca_Denisa_Lab_2Context context)
        {
            _context = context;
        }

      public Category Category { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Category == null)
            {
                return NotFound();
            }

            var category = await _context.Category.FirstOrDefaultAsync(m => m.ID == id);
            if (category == null)
            {
                return NotFound();
            }
            else 
            {
                Category = category;
            }
            return Page();
        }
    }
}
