using Microsoft.EntityFrameworkCore;
using Shop.Data.Interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Repository
{
    public class CarRepository : IAllCars
    {
        public readonly AppDBContent appDBContent;

        public CarRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<Car> Cars { get => appDBContent.Car.Include(c => c.Category); set => throw new NotImplementedException(); }
        public IEnumerable<Car> GetFavCars { get => appDBContent.Car.Where(c => c.isFavourite).Include(c => c.Category); set => throw new NotImplementedException(); }

        public Car GetObjectCar(int id) => appDBContent.Car.FirstOrDefault(p => p.id == id);
    }
}
