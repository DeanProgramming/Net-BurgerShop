using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BurgerShop.Model;

namespace BurgerShop.Data
{
    public class BurgerShopContext : DbContext
    {
        public BurgerShopContext (DbContextOptions<BurgerShopContext> options)
            : base(options)
        {
        }

        public DbSet<BurgerShop.Model.Burger> Burger { get; set; } = default!;
    }
}
