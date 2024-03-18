using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BurgerShop.Data;
using BurgerShop.Model;

namespace BurgerShop.Pages
{
    public class DeleteModel : PageModel
    {
        private readonly BurgerShop.Data.BurgerShopContext _context;

        public DeleteModel(BurgerShop.Data.BurgerShopContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Burger Burger { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Burger == null)
            {
                return NotFound();
            }

            var burger = await _context.Burger.FirstOrDefaultAsync(m => m.UniqueBurgerId == id);

            if (burger == null)
            {
                return NotFound();
            }
            else 
            {
                Burger = burger;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Burger == null)
            {
                return NotFound();
            }
            var burger = await _context.Burger.FindAsync(id);

            if (burger != null)
            {
                Burger = burger;
                _context.Burger.Remove(Burger);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
