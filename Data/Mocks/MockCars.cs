using Shop.Data.Interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _carsCategory = new MockCategory();
        public IEnumerable<Car> Cars
        {
            get
            {
                return new List<Car>
                {
                    new Car {name = "Tesla", shortDesc = "", longDesc = "", img = "/img/tesla.jpg", price = 45000, isFavourite = true, available = true,
                    Category = _carsCategory.AllCategories.First()},
                    new Car {name = "Chevrolet Volt", shortDesc = "", longDesc = "", img = "/img/chevrolet-volt.jpg", price = 45000, isFavourite = false, available = true,
                    Category = _carsCategory.AllCategories.First()},
                    new Car {name = "Mercedes", shortDesc = "", longDesc = "", img = "/img/mercedes.jpg", price = 45000, isFavourite = true, available = false,
                    Category = _carsCategory.AllCategories.Last()}
                };
            }
            set
            {
                throw new NotImplementedException();
            }
        }
        public IEnumerable<Car> GetFavCars { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Car GetObjectCar(int id)
        {
            throw new NotImplementedException();
        }
    }
}
