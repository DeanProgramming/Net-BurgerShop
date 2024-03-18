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
    public class DetailsModel : PageModel
    {
        private readonly BurgerShop.Data.BurgerShopContext _context;

        public DetailsModel(BurgerShop.Data.BurgerShopContext context)
        {
            _context = context;
        }

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
    }
}
