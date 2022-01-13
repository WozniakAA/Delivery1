using Delivery.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Delivery.ViewModels
{
    public class CityListViewModel
    {
        public IEnumerable<ModelCity> GetAllCities { get; set; }

        public string DelCateg { get; set; }
    }
}
