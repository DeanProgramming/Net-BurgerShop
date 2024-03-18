using BurgerShop.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System.Threading.Tasks;

namespace BurgerShop.Data
{
    public class BurgerService
    {
        private readonly BurgerShopContext _context;

        public BurgerService(BurgerShopContext context)
        {
            _context = context;
        }

        public async Task<Burger[]> GetBurgersAsync()
        {
            return await _context.Burger.ToArrayAsync();
        }
    }
}