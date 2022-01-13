using Delivery.Data.interfaces;
using Delivery.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Delivery.Controllers
{
    public class CityController : Controller
    {
        private readonly Icity _allCity;
        private readonly Icateg _allCat;

        public CityController(Icity iicity, Icateg iicat)
        {
            _allCity = iicity;
            _allCat = iicat;
        }

        public ViewResult List()
        {
            CityListViewModel obj = new CityListViewModel();
            obj.GetAllCities = _allCity.cities;
            return View(obj);
        }

    }
}
