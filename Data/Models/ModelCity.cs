using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Delivery.Data.Models
{
    public class ModelCity
    {
        public int id { set; get; }
        public string name { set; get; }
        public virtual ModelCategory Type_c { set; get; }
    }
}
