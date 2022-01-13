using Delivery.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Delivery.Data.interfaces
{
   public interface Icity
    {
      public  IEnumerable<ModelCity> cities { get;}
        ModelCity getobject(int cityid);

    }
}
