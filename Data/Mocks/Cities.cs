using Delivery.Data.interfaces;
using Delivery.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Delivery.Data.mods
{
    public class Cities : Icity
    {
        private readonly Icateg _categ_d = new mock_categ();
        public IEnumerable<ModelCity> cities => new List<ModelCity>
                {
                    new ModelCity { name = "Москва", Type_c = _categ_d.Getallcategories.First() },
                    new ModelCity { name = "Нижний Новгород", Type_c = _categ_d.Getallcategories.Last() },
                    new ModelCity { name = "Нижний Новгород", Type_c = _categ_d.Getallcategories.First() },
                };

        //internal I_city Categ_d => _categ_d;

        public ModelCity getobject(int cityid)
        {
            throw new NotImplementedException();
        }
    }
    
}
