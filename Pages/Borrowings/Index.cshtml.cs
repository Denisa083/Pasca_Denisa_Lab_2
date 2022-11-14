using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Pasca_Denisa_Lab_2.Data;
using Pasca_Denisa_Lab_2.Models;

namespace Pasca_Denisa_Lab_2.Pages.Borrowings
{
    public class IndexModel : PageModel
    {
        private readonly Pasca_Denisa_Lab_2.Data.Pasca_Denisa_Lab_2Context _context;

        public IndexModel(Pasca_Denisa_Lab_2.Data.Pasca_Denisa_Lab_2Context context)
        {
            _context = context;
        }

        public IList<Borrowing> Borrowing { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Borrowing != null)
            {
                Borrowing = await _context.Borrowing.ToListAsync();
            }
        }
    }
}
