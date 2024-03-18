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
    public class IndexModel : PageModel
    {
        private readonly BurgerShop.Data.BurgerShopContext _context;

        public IndexModel(BurgerShop.Data.BurgerShopContext context)
        {
            _context = context;
        }

        public IList<Burger> Burger { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Burger != null)
            {
                Burger = await _context.Burger.ToListAsync();
            }
        }
    }
}
