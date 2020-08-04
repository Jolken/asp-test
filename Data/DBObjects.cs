using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {
            if (!content.Category.Any())
            {
                content.Category.AddRange(Categories.Select(c => c.Value));
            }
            if (!content.Car.Any())
            {
                content.AddRange(
                    new Car
                    {
                        name = "Tesla",
                        shortDesc = "",
                        longDesc = "",
                        img = "/img/tesla.jpg",
                        price = 45000,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Electro car"]
                    },
                    new Car
                    {
                        name = "Chevrolet Volt",
                        shortDesc = "",
                        longDesc = "",
                        img = "/img/chevrolet-volt.jpg",
                        price = 45000,
                        isFavourite = false,
                        available = true,
                        Category = Categories["Electro car"]


                    },
                    new Car
                    {
                        name = "Mercedes",
                        shortDesc = "",
                        longDesc = "",
                        img = "/img/mercedes.jpg",
                        price = 45000,
                        isFavourite = true,
                        available = false,
                        Category = Categories["Classic car"]
                    }
                );
            }

            content.SaveChanges();
        }

        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (category == null)
                {
                    List<Category> list = new List<Category>
                    {
                        new Category{ categoryName = "Electro car",  desc = "Brand new type of cars",},
                        new Category { categoryName = "Classic car",  desc = "Classic cars with....", }
                    };
                    category = new Dictionary<string, Category>();
                    foreach (var c in list)
                    {
                        category.Add(c.categoryName, c);
                    }
                }
                return category;
            }
        }
    }
}
