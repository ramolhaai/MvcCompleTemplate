using myDataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MySampleApi.Business;
using myDataLayer.EF;
using myDataLayer;

namespace MySampleApi.Controllers
{
    public class ValueCController : ApiController
    {
      
       private readonly ICaclulator _caclulator;
       private readonly GlobalAMEntities _db;
       private readonly IProductRepository _db2;
        //plain  interface
       public ValueCController(ICaclulator calculator, GlobalAMEntities Db, IProductRepository db2)
       {
            _caclulator = calculator;
            _db = Db; //new GlobalAMEntities();
            _db2 = db2;
          
        }

            
        public int Get(int num1, int num2)
        {
            return _caclulator.Add(num1, num2);
        }

        

        public int Get2()
        {
            var icnt = _db2.Getuam2_market1().ToList().Count();
            return icnt;
        }
    }
}
