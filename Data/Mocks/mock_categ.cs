using Delivery.Data.interfaces;
using Delivery.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Delivery.Data.mods
{
   public class mock_categ : Icateg
    {

       public IEnumerable<ModelCategory> Getallcategories
        {
            get
            {
                return new List<ModelCategory>
            {
                new ModelCategory { categotyname = "Авиадоставка", descript = "Срочные пересылки" },
                new ModelCategory { categotyname = "ЖДдоставка", descript = "Дешево и надежно" },
                new ModelCategory { categotyname = "Автодоставка", descript = "Небольшие дистанции" }
            };
            }
        }
    }
}
