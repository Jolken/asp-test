using Microsoft.AspNetCore.Mvc;
using Shop.Data.Interfaces;
using Shop.Data.Mocks;
using Shop.Data.Models;
using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    public class CarsController : Controller
    {
        private readonly IAllCars _allCars;
        private readonly ICarsCategory _allCategories;

        public CarsController(IAllCars iAllCars, ICarsCategory iCarsCat)
        {
            _allCars = iAllCars;
            _allCategories = iCarsCat;
        }

        [Route("Cars/List")]
        [Route("Cars/List/{category}")]
        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Car> cars;

            string currCategory = "";

            if (string.IsNullOrEmpty(category))
            {
                cars = _allCars.Cars;
            }
            else if (new[]{ "e", "ele", "electro"}.Contains(category))
            {
                cars = _allCars.Cars.Where(c => c.Category.categoryName == "Electro car");
            }
            else if (new[] { "c", "fuel","f", "classic" }.Contains(category))
            {
                cars = _allCars.Cars.Where(c => c.Category.categoryName == "Classic car");
            }
            else
            {
                cars = _allCars.Cars;
            }


            ViewBag.Title = "Страница с автомобилями";
            CarsListViewModel carsListViewModel = new CarsListViewModel()
            {
                AllCars = cars,
                currCategory = category
            };
            return View(carsListViewModel);
        }
    }
}
