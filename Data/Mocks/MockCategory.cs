using Shop.Data.Interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories { 
            get
            {
                return new List<Category>
                {
                    new Category
                    {
                        categoryName = "Electro car",
                        desc = "Brand new type of cars",
                    },
                    new Category
                    {
                        categoryName = "Classic car",
                        desc = "Classic cars with....",
                    }
                };
            } 
        }
    }
}
