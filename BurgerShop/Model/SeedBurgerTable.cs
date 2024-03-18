using BurgerShop.Data;
using Microsoft.EntityFrameworkCore;

namespace BurgerShop.Model
{
    public class SeedBurgerTable
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (
                var context = new BurgerShopContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<BurgerShopContext>>()))
            {
                if (context == null || context.Burger == null)
                {
                    throw new ArgumentNullException("Null RazorPagesBurgerContext");
                }


                if (context.Burger.Any())
                {
                    return;   // DB has been seeded
                }


                context.Burger.AddRange(
                    new Burger
                    {
                        UniqueBurgerId = 1,
                        Name = "Basic Burger",
                        Description = "The most basic burger",
                        Price = 10,
                        Vegetarian = false,
                        Vegan = false,
                        ImageURL = "img/burgers/ClassicBurger.jpg"
                    },
                    new Burger
                    {
                        UniqueBurgerId = 2,
                        Name = "Vegan Burger",
                        Description = "The vegan burger",
                        Price = 8,
                        Vegetarian = true,
                        Vegan = true,
                        ImageURL = "img/burgers/VeganBurger.jpg"
                    },
                    new Burger
                    {
                        UniqueBurgerId = 3,
                        Name = "Tower Burger",
                        Description = "The Tower burger",
                        Price = 18,
                        Vegetarian = false,
                        Vegan = false,
                        ImageURL = "img/burgers/TowerBurger.jpg"
                    }
                );

                context.SaveChanges();
            }
        }
    }
}